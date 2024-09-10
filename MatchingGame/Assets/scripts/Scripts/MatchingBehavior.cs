using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchingBehavior : MonoBehaviour   
{
    public ID iDobj;
    public UnityEvent matchingEvent, noMatchingEvent, nomMatchDelayEvent;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempID = other.GetComponent<IDContainerBehavior>();
        if (tempID == null)
            yield break;    
        var otherID = tempID.iDobj;
        if (otherID == iDobj)
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
