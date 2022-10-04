using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   private void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed",Mathf.Abs (speed));
        Vector3 scale = transform.localScale;
        if (speed < 0)
        {
            scale.x = -1f * scale.x;

        }else if (speed > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;

    }

    //Crouch
    private void PlayerCrouch()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {

            animator.SetBool("Crouch", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {

            animator.SetBool("Crouch", false);
        }

    }

    //JUMP       
    private void PlayerJump(float horizontal)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Jump", true);

        }

        else
        {
            animator.SetBool("Jump", false);
        }


    }
}