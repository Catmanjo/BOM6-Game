using System;
using System.Collections;
using UnityEngine;
public class SwordTrigger : MonoBehaviour
{
    private BoxCollider2D Bc2d;
    public static event Action<GameObject> DmgStone;

    void Start()
    {
        Bc2d = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.J))
        {
            StartCoroutine(SwingSword());
        }
    }

    IEnumerator SwingSword()
    {
        Bc2d.enabled = true;
        yield return new WaitForSeconds(0.5f);
        Bc2d.enabled = false;
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        if (other.CompareTag("Stone"))
        {
            DmgStone.Invoke(gameObject);
        }
    }
}