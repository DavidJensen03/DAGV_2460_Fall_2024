using UnityEngine;
[CreateAssetMenu]
public class floatData : ScriptableObject
{
    public float value;

    public void resetValue(int num)
    {
    value = num;
    }
    public void UpdateValue(int num) 
    {
        value += num;
    }
}
