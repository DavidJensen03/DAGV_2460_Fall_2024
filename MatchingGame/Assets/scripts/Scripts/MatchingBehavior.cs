using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchingBehavior : MonoBehaviour   
{
    public ID IdObj;
    public UnityEvent matchingEvent, noMatchingEvent, nomMatchDelayEvent;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempID = other.GetComponent<IDContainerBehavior>();
        if (tempID == null)
            yield break;    
        var otherID = tempID.IdObj;
        if (otherID == IdObj)
        {
            matchingEvent.Invoke();
        }
        else
        {
           noMatchingEvent.Invoke();
           yield return new WaitForSeconds(0.5f);
           noMatchingEvent.Invoke();
        }
    }
}
