using TMPro;
using UnityEngine;

public class MoneyHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    private float rizz;
    void Start()
    {
        MoneyPickUp.OnPickUp += AddMoney;
    }
    void Update()
    {
        text.text = rizz.ToString();
    }
    private void AddMoney(GameObject gameObject)
    {
        rizz += 10f;
    }
}
