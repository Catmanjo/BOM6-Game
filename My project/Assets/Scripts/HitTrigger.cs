using UnityEngine;
public class HitTrigger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike")) 
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}