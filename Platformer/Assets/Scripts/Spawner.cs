using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Camera Camera;
    public GameObject prefab;
    public Vector3 Offset;

    private void Start()
    {
        Offset = new Vector3(0, -.5f, 1.5f);
    }
    public void CreatInstance()
    {
        Instantiate(prefab, Camera.transform.position + Offset, Quaternion.identity);
        
    }
}
