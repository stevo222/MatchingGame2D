using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CouratineBehavior : MonoBehaviour
{


    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalse;
    public bool canRun;
    public IntData counterNum;
    public float seconds = 3.8f;
    private WaitForSeconds WfsObj;
    private WaitForFixedUpdate WffuObj;

    private void Start()
    {
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    
    // Start is called before the first frame update
    private IEnumerator Counting()
    {
        WfsObj = new WaitForSeconds(seconds);
        WffuObj = new WaitForFixedUpdate();
        startCountEvent.Invoke();
        yield return WfsObj;

        while (counterNum.value > 0)
        {
            //Debug.Log(counterNum);
            
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return WfsObj;
            
        }
        endCountEvent.Invoke();
        
        
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatuntilFalse());
    }
    private IEnumerator RepeatuntilFalse()
    {
        while (canRun)
        {
            yield return WfsObj;
            repeatUntilFalse.Invoke();
        }
    }
    

  
}
