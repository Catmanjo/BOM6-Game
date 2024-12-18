using UnityEngine;
public class jump : MonoBehaviour
{
    private bool isGrounded;
    private Rigidbody2D rb;

    [SerializeField] private float JumpForce;
    [SerializeField] private float JumpHoldForce;
    [SerializeField] private float JumpHoldDuration;

    private bool isJumping = false;
    private float JumpHoldTime;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isJumping = true;
            JumpHoldTime = 0f;
            rb.velocity = new Vector2(rb.velocity.x, JumpForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space) && isJumping)
        {
            if (JumpHoldTime < JumpHoldDuration)
            {
                rb.AddForce(new Vector2(0, JumpHoldForce), ForceMode2D.Force);
                JumpHoldTime += Time.deltaTime;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
            if (rb.velocity.y > 0)
            {
                rb.velocity = Vector2.zero;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;//
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