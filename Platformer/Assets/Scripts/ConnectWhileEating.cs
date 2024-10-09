using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ConnectWhileEating : MonoBehaviour
{
    public UnityEvent whileHolding;
    private void OnTriggerEnter(Collider other)
    {
        whileHolding.Invoke();
        transform.SetParent(other.transform);
    }

    
}
