using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehavior : MonoBehaviour
{
    public colorID iDobj;
    public UnityEvent startEvent;
    public void Start()
    {
        startEvent.Invoke();
    }
}