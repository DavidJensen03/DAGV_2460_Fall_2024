using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class isColourData : ScriptableObject
{
    public string whatColour;
    public void changeColor(string newColor)
    {
        whatColour = newColor;
        Debug.Log(whatColour);
    }
}
