using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]
public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent TriggerEvent;
    private void OnTriggerEnter (Collider other)
    {
        TriggerEvent.Invoke ();
    }
}