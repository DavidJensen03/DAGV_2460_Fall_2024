using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ColorIdDataList : ScriptableObject
{
    public List<colorID> colorIdList;
    public colorID curremtColor;

    private int num;
    public void SetCurremtColorRandomly()
    {
        num = colorIdList.Count - 1;
        curremtColor = colorIdList[num];
    }
}
