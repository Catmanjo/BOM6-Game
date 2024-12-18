using System.Collections;
using UnityEngine;

public class HitTrigger : MonoBehaviour
{
    [SerializeField] private string Target;
    [SerializeField] private bool fun;

    [SerializeField] private SpriteRenderer sr = new SpriteRenderer();
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private ConstantForce2D force;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Target)) // Changes color if hit by sword hitbox
        {
            sr.color = Color.red;
            if(fun == true)
            {
                StartCoroutine(Fun());
            }
        }
    }

    IEnumerator Fun()
    {
        force.torque = 10;
        yield return new WaitForSeconds(10);
        force.torque = 1000;
        yield return new WaitForSeconds(5);
        rb.gravityScale = -10f;
        yield return new WaitForSeconds(1);
        rb.gravityScale = 10;
        yield return new WaitForSeconds(1);
    }// Joke function, will be deleted soon
}
