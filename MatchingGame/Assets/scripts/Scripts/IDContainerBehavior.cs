using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehavior : MonoBehaviour
{
    public colorID IdObj;
    public UnityEvent startEvent;
    public void Start()
    {
        startEvent.Invoke();
    }
}