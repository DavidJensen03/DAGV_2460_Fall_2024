using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class vecter3data : ScriptableObject
{
    public Vector3 vector3Data;
    public void newPostionOfLastTouch()
    {
        vector3Data = GameObject.Find("Player").transform.position;
        Debug.Log(vector3Data);
    }

}
