using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class textLabelBehaviorVector : MonoBehaviour
{
        public Text label2;
        public vecter3data dataObj2;
    private void Start()
    {
        label2 = GetComponent<Text>();
        updateLabel();
    }
    public void updateLabel()
    {
        label2.text = dataObj2.vector3Data.ToString();
    }
}
