using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu]
public class intData : ScriptableObject
{
    public int value;

    public void updateValue(int number)
    {
        value += number;
    }
    public void replaceValue(int number)
    {
        value = number;
    }
   // public void DisplayImage(Image img)
  //  {
        // i couldnt get this one working :/
  //  }
   // public void DisplayNumber(Text txt)
   // {
        //txt.text = value.ToString();
        // this one didnt work either for some reson
  //  }
}
