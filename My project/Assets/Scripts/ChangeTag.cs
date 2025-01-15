using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTag : MonoBehaviour
{
    public string FallenTag = "Ground";
    public string NewTag = "FallenSpike";
    private Rigidbody2D rb;
    private BoxCollider2D bx;

    private void Start()
    {
        Debug.Log("Script exists");
        rb = GetComponent<Rigidbody2D>();
        bx = GetComponent<BoxCollider2D>();
        if (rb == null)
        {
            Debug.LogError("No Rigidbody2D found on this object!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"Collided with: {collision.gameObject.name}");
        if (collision.gameObject.CompareTag(FallenTag))
        {
            Debug.Log("Tag matches!");
            gameObject.tag = NewTag;
            rb.bodyType = RigidbodyType2D.Static;
            bx.enabled = false;
            rb.simulated = false;
        }
    }
}
