using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveright : MonoBehaviour
{
    public float speed = .02f;
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
