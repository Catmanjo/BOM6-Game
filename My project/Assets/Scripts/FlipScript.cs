using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localScale = new Vector3(-1.2f,1.7f,1f);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localScale = new Vector3(1.2f,1.7f,1f);
        }
    }
}
