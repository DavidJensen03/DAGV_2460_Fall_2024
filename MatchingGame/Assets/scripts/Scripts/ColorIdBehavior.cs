using Unity.Jobs;
using UnityEngine;

public class ColorIdBehavior : IDContainerBehavior
{
    public ColorIdDataList colorIDDataListObj;

    private void Awake()
    {
        IdObj = colorIDDataListObj.currentColor;
    }
}
