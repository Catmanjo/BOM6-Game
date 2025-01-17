using UnityEngine;
public class ChangeTag : MonoBehaviour
{
    private string FallenTag = "Ground";
    private string NewTag = "FallenSpike";
    private Rigidbody2D rb;
    private BoxCollider2D bx;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bx = GetComponent<BoxCollider2D>();
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