using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatingAnimatior : MonoBehaviour
{
    public Animator animator;
    private readonly int idle = Animator.StringToHash("idle");
    private readonly int walk = Animator.StringToHash("walk");
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.ResetTrigger(idle);
            animator.SetTrigger(walk);
        }
        else if ((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) && (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)))
        {
            animator.ResetTrigger(walk);
            animator.SetTrigger(idle);
        }
    }

}
