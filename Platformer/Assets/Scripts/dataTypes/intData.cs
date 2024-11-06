using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class intData : ScriptableObject
{
    public int value;


    public void setValue(int num)
    {
        value = num;
    }
    public void CompareValue(intData obj)
    {
        if (value >= obj.value)
        {

        }
        else
        {
            value = obj.value;
        }
    }
    public void setValue(intData obj)
    {
        value = obj.value;
    }

    public void updateValue(int number)
    {
        value += number;
    }
}
