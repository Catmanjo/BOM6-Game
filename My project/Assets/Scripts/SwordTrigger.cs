using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTrigger : MonoBehaviour
{
    [SerializeField] private BoxCollider2D bc2d = new BoxCollider2D();
    [SerializeField] private SpriteRenderer sr = new SpriteRenderer();

    void Start()
    {
        sr.color = Color.green;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(SwingSword());
        }
    }


    IEnumerator SwingSword() //Swings sword
    {
        bc2d.enabled = true;
        sr.color = Color.red;
        yield return new WaitForSeconds(1);
        bc2d.enabled = false;
        sr.color = Color.green;
    }
}
