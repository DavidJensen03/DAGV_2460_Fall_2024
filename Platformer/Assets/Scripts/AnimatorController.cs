using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator animator;
    private readonly int idle = Animator.StringToHash("idle");
    private readonly int walk = Animator.StringToHash("walk");

    public BoolData AllowedToWalk;
    public bool pointingleft = true;
    public GameObject charecter;
    public Vector3 pointingDirection;

    private void Start()
    {
        pointingDirection = new Vector3(charecter.transform.eulerAngles.x, charecter.transform.eulerAngles.y + 180, charecter.transform.eulerAngles.z);
  
    }

    private void Update()
    {

        if (AllowedToWalk == true)
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
            directionMover();
        }
    }

    private void directionMover()
    {
        if (pointingleft == false)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                charecter.transform.eulerAngles = -pointingDirection;
                pointingleft = true;

            }
        }
        if (pointingleft == true)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                charecter.transform.eulerAngles = pointingDirection;
                pointingleft = false;
            }
        }

    }
}