using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class RepeatingAction : MonoBehaviour
{
    public float seconds = 5f;
    private WaitForSeconds _waitForSeconds;
    public UnityEvent RepeatingEvent1, RepeatingEvent2;
    public bool AllowedToRun1 = true;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(seconds);
    }

    public void startRpeatingAction()
    {
        StartCoroutine(Starter1());

    }
    private IEnumerator Starter1()
    {
        while (AllowedToRun1)
        {
            yield return _waitForSeconds;
            RepeatingEvent1.Invoke();
            yield return _waitForSeconds;
            RepeatingEvent2.Invoke();
        }
    }

}
