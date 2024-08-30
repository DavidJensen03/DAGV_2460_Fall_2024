
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent AwakeEvent, StartEvent, DisableEvent;

    public void Awake()
    {
        AwakeEvent.Invoke();
    }
    public void Start()
    {
        StartEvent.Invoke();
    }
    public void OnDisable()
    {
        DisableEvent.Invoke();
    }
}
