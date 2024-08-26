using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class textLabelBehaviorColour : MonoBehaviour
{
        public Text label3;
        public isColourData dataObj3;
    private void Start()
    {
        label3 = GetComponent<Text>();
        updateLabel();
    }
    public void updateLabel()
    {
        label3.text = dataObj3.whatColour.ToString();
    }
}
