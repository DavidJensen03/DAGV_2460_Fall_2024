using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class parentSkript : MonoBehaviour
{
    public GameObject cam;

    private void Awake()
    {
        cam = GameObject.Find("MainCamera");
        SetParent();
    }
    public void SetParent()
    {
        //Makes the GameObject "newParent" the parent of the GameObject "player".
        transform.parent = cam.transform;

        //Display the parent's name in the console.
        Debug.Log("Player's Parent: " + cam.transform.parent.name);



    }
}
