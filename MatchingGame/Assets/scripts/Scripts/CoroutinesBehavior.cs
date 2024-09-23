using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutinesBehavior : MonoBehaviour
{

    public UnityEvent StartEvent, StartCountEvent, RepeatingCountEvent, EndCountEvent, repeatUntellFalseEvent;
    public intData counterNum;
    private bool canRun;

    public float seconds = 3.0f;

    private WaitForSeconds WaitSecObject;
    private WaitForFixedUpdate WaitFixedObject;

    public bool CanRun 
    { 
      get => canRun; 
      set => canRun = value; 
    }

    private void Start()
    {
        WaitSecObject = new WaitForSeconds(seconds);
        WaitFixedObject = new WaitForFixedUpdate();
        StartEvent.Invoke();
    }
    public void StartCounting()
    {
        StartCoroutine(Counting());

    }
    IEnumerator Counting()
    {
        StartCountEvent.Invoke();
        
       

        yield return WaitSecObject;
        while (counterNum.value > 0) 
        {
            Debug.Log(counterNum.value);
            RepeatingCountEvent.Invoke();
            counterNum.value--;
            yield return WaitSecObject;
        }
        EndCountEvent.Invoke();
    }
    public void StartRepeatingUntellFalse()
    {
        Debug.Log("dsddd");
        canRun = true;
        StartCoroutine(RepeatingTelFalse());
    }
    IEnumerator RepeatingTelFalse()
    {
        while (canRun)
        {
            
            yield return WaitSecObject;
            repeatUntellFalseEvent.Invoke();
        
        }
    }
    

}
