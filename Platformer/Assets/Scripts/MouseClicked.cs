using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseClicked : MonoBehaviour
{
    public UnityEvent AteObj;
    private void OnMouseDown()
    {
        Debug.Log("clicked");
        AteObj.Invoke();
    }
}
