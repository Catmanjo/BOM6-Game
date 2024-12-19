using System;
using UnityEngine;

public class MoneyPickUp : MonoBehaviour
{
    public static event Action<GameObject> OnPickUp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnPickUp.Invoke(gameObject);
            Destroy(transform.parent.gameObject);
        }
    }
}
