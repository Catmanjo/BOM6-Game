using UnityEngine;

public class HitTrigger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr = new SpriteRenderer();

    [SerializeField] private string Target;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Target))
        {
            sr.color = Color.red;
        }
    }
}
