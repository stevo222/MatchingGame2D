using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CouratineBehavior : MonoBehaviour
{


    public UnityEvent repeatEvent;
    public int counterNum = 3;
    public float seconds = 3.8f;
    private WaitForSeconds WfsObj;
    private WaitForFixedUpdate WffuObj;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        WfsObj = new WaitForSeconds(seconds);
        WffuObj = new WaitForFixedUpdate();

        while (counterNum > 0)
        {
            Debug.Log(counterNum);
            yield return WfsObj;
            repeatEvent.Invoke();
            counterNum--;
            
        }
        
    }

  
}
