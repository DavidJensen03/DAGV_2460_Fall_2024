using UnityEngine;
using UnityEngine.Events;

public class CompareIntdataThenEvents : MonoBehaviour
{
    public intData BitesNeeded;
    public UnityEvent BitesNeededMet;
    public void CompareThese(intData bitesTaken)
    {
        if (bitesTaken.value == BitesNeeded.value)
        {
            BitesNeededMet.Invoke();    
        }
        Debug.Log(bitesTaken.value);
    }
}
