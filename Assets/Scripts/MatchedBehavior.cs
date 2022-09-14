
using UnityEngine;
using UnityEngine.Events;

public class MatchedBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, nomatchEvent;

    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log(idObj);
        //Debug.Log(other.GetComponent<IDContainerBehavior>().idobj);
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
            return;
        var otherID = tempObj.idobj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            nomatchEvent.Invoke();    
        }
    }
}
