using System;
using UnityEngine;

public class jump : MonoBehaviour
{
    private bool isGrounded;
    private Rigidbody2D rb;
    [SerializeField] private float jumpforce = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Console.WriteLine("saygex");
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}