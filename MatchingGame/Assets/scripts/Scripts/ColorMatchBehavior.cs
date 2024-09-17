using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehavior : MatchingBehavior
{
    public ColorIdDataList colorIDDataLisstObj;

    private void Awake()
    {
        iDobj = colorIDDataLisstObj.curremtColor;
    }

    public void changeColor(SpriteRenderer renderer)
    {
        var newColor = iDobj as colorID;
        renderer.color = newColor.value;


    }
}

