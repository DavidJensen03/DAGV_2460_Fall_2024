using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent collectedEvent;
    private void OnTriggerEnter (Collider other)
    {
        collectedEvent.Invoke ();
    }
}