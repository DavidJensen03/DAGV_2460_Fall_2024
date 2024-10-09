using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class deleatedOnceCollected : MonoBehaviour
{
    public UnityEvent oncedestroyed;
    public float TimeBeforeDestroy = 1f;

    private WaitForSeconds waitForSeconds;

    private void Start()
    {
        waitForSeconds = new WaitForSeconds(TimeBeforeDestroy);
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        
        oncedestroyed.Invoke();
        yield return waitForSeconds;
        Destroy(gameObject);
    }
}
