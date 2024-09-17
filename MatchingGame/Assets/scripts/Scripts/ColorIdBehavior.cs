using UnityEngine;

public class ColorIdBehavior : IDContainerBehavior
{
    public ColorIdDataList colorIDDataLisstObj;

    private void Awake()
    {
        iDobj = colorIDDataLisstObj.curremtColor;
    }
}
