using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CouratineBehavior : MonoBehaviour
{


    public UnityEvent startEvent, repeatEvent, endEvent;
    
    public IntData counterNum;
    public float seconds = 3.8f;
    private WaitForSeconds WfsObj;
    private WaitForFixedUpdate WffuObj;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        WfsObj = new WaitForSeconds(seconds);
        WffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
        yield return WfsObj;

        while (counterNum.value > 0)
        {
            //Debug.Log(counterNum);
            
            repeatEvent.Invoke();
            counterNum.value--;
            yield return WfsObj;
            
        }
        endEvent.Invoke();
        
    }

  
}
