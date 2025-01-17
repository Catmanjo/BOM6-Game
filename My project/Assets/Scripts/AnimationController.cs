using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator ac;

    private void Start()
    {
        ac = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) // Checks if walking
        {
            ac.SetBool("Walking", true);
        }
        else
        {
            ac.SetBool("Walking", false);
        }
    }
}