using System.Collections.Generic;
using UnityEngine;

public class DriveByShooting : MonoBehaviour
{
    [SerializeField] private GameObject money;
    private List<GameObject> MoneyInList = new List<GameObject>();

    void Start()
    {
        DestroyedChest();
    }
    private void Update()
    {

    }
    private void DestroyedChest()
    {
        Destroy(gameObject);
        for (int i = 0; i < 5; i++)
        {
            GameObject ChestMoney = Instantiate(money, transform.position, Quaternion.identity);
            MoneyInList.Add(ChestMoney);
        }
        foreach (GameObject ChestMoney in MoneyInList)
        {
            Rigidbody2D rb = ChestMoney.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * 20f, ForceMode2D.Force);
        }
    }
}