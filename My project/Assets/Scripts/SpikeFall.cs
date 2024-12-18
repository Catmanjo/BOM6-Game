using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeFall : MonoBehaviour
{
    public Transform Spike;
    public float DetectRange = 6f;
    public float HorizontalRange = 2f;
    public string Tag = "Player";
    private Rigidbody2D rb;
    void Start()
    {
        rb = Spike.GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Geen Rigidbody, doe er iets aan!");
        }
        rb.bodyType = RigidbodyType2D.Static;
    }

    void Update()
    {
        Vector2 boxSize = new Vector2(HorizontalRange, DetectRange);
        RaycastHit2D hit = Physics2D.BoxCast(Spike.position, boxSize, 0f, Vector2.down, DetectRange);
        if (hit.collider != null && hit.collider.CompareTag(Tag))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
