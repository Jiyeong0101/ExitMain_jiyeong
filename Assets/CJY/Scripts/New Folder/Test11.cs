using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test11 : MonoBehaviour
{
    public MoneyManager moneyManager;

    void Update()
    {
        // 1�� Ű ������ �� �� �߰�
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            moneyManager.AddMoney(100); // 100�� �߰�
            Debug.Log("�� �߰���: +100");
        }

        // 2�� Ű ������ �� �� ���
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            bool success = moneyManager.SpendMoney(50); // 50�� ���
            Debug.Log(success ? "�� ����: -50" : "�� �����ؼ� ��� �Ұ�");
        }
    }
}
