using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class delayedEvent : MonoBehaviour
{
    public UnityEvent DelayedEvent;

    private WaitForSeconds WaitSecObject;
    private WaitForFixedUpdate WaitFixedObject;
    public float seconds; 

    void Start()
    {
        WaitSecObject = new WaitForSeconds(seconds);
        WaitFixedObject = new WaitForFixedUpdate();
    }
    public void StartdelayedAction()
    {
        StartCoroutine(delayedAction());
    }
    IEnumerator delayedAction()
    {
        yield return WaitSecObject;
        DelayedEvent.Invoke();
    }
}
