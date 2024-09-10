using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class draggableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    private bool draggable;
    public Vector3 postion, offset;
    public UnityEvent startDragEvent, endDragEvent;
    void Start()
    {
        cameraObj = Camera.main;
    }
    public IEnumerator OnMouseDown()
    {
        startDragEvent.Invoke();
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        yield return new WaitForFixedUpdate();
        while (draggable) 
        {
            yield return new WaitForFixedUpdate();
            postion = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = postion;
        }
    }
    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }

}
