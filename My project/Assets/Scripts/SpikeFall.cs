using UnityEngine;
public class SpikeFall : MonoBehaviour
{
    private Transform Spike;
    private float DetectRange = 20f;
    private float HorizontalRange = 3f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Static;
    }

    void Update()
    {
        Vector2 boxSize = new Vector2(HorizontalRange, DetectRange);
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, boxSize, 0f, Vector2.down, DetectRange);
        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {
                
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}