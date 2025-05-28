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
    /// 재화를 추가
    /// </summary>
    public void AddMoney(int amount)
    {
        currentMoney += amount;
        onMoneyChanged?.Invoke(currentMoney); //UI업데이트
    }

    /// <summary>
    /// 재화를 사용. 성공 시 true 반환
    /// </summary>
    public bool SpendMoney(int amount)
    {
        if (CanAfford(amount))
        {
            currentMoney -= amount;
            onMoneyChanged?.Invoke(currentMoney); //UI업데이트
            return true;
        }

        return false;
    }

    /// <summary>
    /// 재화가 충분한지 확인
    /// </summary>
    public bool CanAfford(int amount)
    {
        return currentMoney >= amount;
    }
}
