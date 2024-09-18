using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehavior : MatchingBehavior
{
    public ColorIdDataList colorIDDataListObj;
   
    private void Awake()
    {
        IdObj = colorIDDataListObj.currentColor;
    }

    public void changeColor(SpriteRenderer renderer)
    {
        var newColor = IdObj as colorID;
        renderer.color = newColor.value;

    }
}

