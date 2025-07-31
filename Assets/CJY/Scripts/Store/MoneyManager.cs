using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoneyManager : MonoBehaviour
{
    [SerializeField]
    private int currentMoney = 0;

    public UnityEvent<int> onMoneyChanged;

    public int CurrentMoney => currentMoney;

    /// <summary>
    /// ��ȭ�� �߰�
    /// </summary>
    public void AddMoney(int amount)
    {
        currentMoney += amount;
        onMoneyChanged?.Invoke(currentMoney); //UI������Ʈ
    }

    /// <summary>
    /// ��ȭ�� ���. ���� �� true ��ȯ
    /// </summary>
    public bool SpendMoney(int amount)
    {
        if (CanAfford(amount))
        {
            currentMoney -= amount;
            onMoneyChanged?.Invoke(currentMoney); //UI������Ʈ
            return true;
        }

        return false;
    }

    /// <summary>
    /// ��ȭ�� ������� Ȯ��
    /// </summary>
    public bool CanAfford(int amount)
    {
        return currentMoney >= amount;
    }
}
