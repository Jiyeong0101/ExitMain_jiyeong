using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    public TMP_Text moneyText;
    public MoneyManager moneyManager;

    private void Start()
    {
        moneyManager.onMoneyChanged.AddListener(UpdateMoneyUI);
        UpdateMoneyUI(moneyManager.CurrentMoney);
    }

    private void UpdateMoneyUI(int money)
    {
        moneyText.text = $"{money}";
    }
}
