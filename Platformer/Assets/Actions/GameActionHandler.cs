using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent, respondLateEvent;
    public float holdTime = 0.1f;
    private WaitForSeconds waitObj;

    private void Start()
    {
        waitObj = new WaitForSeconds(holdTime);
        gameActionObj.RaiseNoArgs += Raise;
    }
    private void Raise()
    {
        onRaiseEvent.Invoke();
        StartCoroutine(RespondLate());
    }
    private IEnumerator RespondLate()
    {
        yield return waitObj;
        respondLateEvent.Invoke();
    }
}