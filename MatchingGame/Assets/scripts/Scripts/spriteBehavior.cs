using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class spriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    private void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }
    public void ChangeRendererColor(colorID obj)
    {
        rendererObj.color = obj.value;
    }
    public void ChangeRendereColor(ColorIdDataList obj)
    {
        rendererObj.color = obj.curremtColor.value;
    }
}
