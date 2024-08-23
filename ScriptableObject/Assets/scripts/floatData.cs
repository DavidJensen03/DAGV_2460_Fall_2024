using UnityEngine;
[CreateAssetMenu]
public class floatData : ScriptableObject
{
    public float value;

    public void UpdateValue(int num) 
    {
        value += num;
    }
}
