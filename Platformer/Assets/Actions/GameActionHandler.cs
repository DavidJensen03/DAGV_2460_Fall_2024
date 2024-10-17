using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent;

    private void Start()
    {
        gameActionObj.RaiseNoArgs += Raise;
    }
    private void Raise()
    {
        onRaiseEvent.Invoke();
    }
}