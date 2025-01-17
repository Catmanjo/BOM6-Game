using TMPro;
using UnityEngine;
public class MoneyHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    private float MoneyInPocket;

    void Start()
    {
        MoneyPickUp.OnPickUp += AddMoney;
    }

    void Update()

    {
        text.text = MoneyInPocket.ToString();
    }
    private void AddMoney(GameObject gameObject)

    {
        MoneyInPocket += 10f;
    }
}
