using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class textLabelBehavior : MonoBehaviour
{
    private Text label;
    public UnityEvent startEvent;
    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }
    public void updatelabel(intData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    
    }
}
