using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
[CreateAssetMenu]
public class ColorIdDataList : ScriptableObject
{
    public List<colorID> colorIDList;

    public colorID currentColor;

    private int num;

    public void SetCurrentColorRandomly()
    {
        num = Random.Range(0, 3);
        currentColor = colorIDList[num];
        Debug.Log(num);
    }
}
