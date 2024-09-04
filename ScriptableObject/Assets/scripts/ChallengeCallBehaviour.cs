using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;

public class ChallengeCallBehaviour : MonoBehaviour
{
    // This script basically changes both the color of the sprite and the scale fo the sprite when you put your mouse over it. and it resets the sprite once you take your mouse off it. 

    public UnityEvent challangeBehaviour1, challangeBehaviour2;
    public SpriteRenderer curColor;
    
    public void OnMouseEnter()
    {
        challangeBehaviour1.Invoke();
       
    }
    public void OnMouseExit()
    {
        challangeBehaviour2.Invoke();
    }

    public void Start()
    {
        
        curColor = GetComponent<SpriteRenderer>();
        curColor.color = UnityEngine.Color.white;
    }

    //changes color when mouse rulls over it. 
    public void changeToRed()
    {
        curColor.color = new UnityEngine.Color(.9f, .8f, .8f, 1);
    }
    public void changeTowhite()
    {
        curColor.color = new UnityEngine.Color(1, 1, 1, 1);
    }
    public void changeSize(float scaleFacter)
    {
        transform.localScale = new Vector2(scaleFacter, scaleFacter);
    }
  
}
