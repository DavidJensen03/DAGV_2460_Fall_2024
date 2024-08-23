using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class textLabelBehavior : MonoBehaviour
{
        public Text label;
        public floatData dataObj;
    private void Start()
    {
        label = GetComponent<Text>();
        updateLabel();
    }
    public void updateLabel()
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
