using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator ac;
    private bool facingRight = true;

    private void Start()
    {
        ac = GetComponent<Animator>();
        
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) // Checks if walking
        {
            ac.SetBool("Walking", true);


            if (Input.GetKey(KeyCode.A) && facingRight) // Moving left and currently facing right
            {
                //Flip();
            }
            else if (Input.GetKey(KeyCode.D) && !facingRight) // Moving right and currently facing left
            {
                //Flip();
            }
        }
        else
        {
            ac.SetBool("Walking", false);
        }
    }

    //void Flip()
    //{
    //    facingRight = !facingRight;
    //    Vector3 scale = transform.localScale;
    //    scale.x *= -1;  // Flip the character without changing scale magnitude
    //    transform.localScale = scale;
    //}
}