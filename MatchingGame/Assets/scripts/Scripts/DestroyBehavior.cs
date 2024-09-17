using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public float secounds = 1;
    private WaitForSeconds wfsObj;
    private IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(secounds);
        yield return wfsObj;
        Destroy(gameObject);
    }

}
