using Unity.VisualScripting;
using UnityEngine;
public class walk : MonoBehaviour
{
    private float moveSpeed;
    private float moveSpeedGround = 7f;
    private float moveSpeedAir = 4f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (rb.velocity.y == 0)
        {
            moveSpeed = moveSpeedGround;
        }
        else
        {
            moveSpeed = moveSpeedAir;
        }
    }
}