using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHnadler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent;

    private void Start()
    {
        gameActionObj.raise += Raise;
    }
    private void Raise()
    {
        onRaiseEvent.Invoke();
    }
}
