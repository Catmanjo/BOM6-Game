using System.Collections.Generic;
using UnityEngine;
public class DriveByShooting : MonoBehaviour
{
    [SerializeField] private GameObject money;
    private List<GameObject> MoneyInList = new List<GameObject>();
    private float StoneHp = 3;

    private void Start()
    {
        SwordTrigger.DmgStone += DamageStone;
    }

    private void Update()
    {
        if (StoneHp <= 0)
        {
            DestroyedChest();
        }
    }
    private void DamageStone(GameObject gameObject)
    {
        StoneHp -= 1f;
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
            rb.AddForce(transform.up * 25f, ForceMode2D.Force);
        }
    }
}