using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test11 : MonoBehaviour
{
    public MoneyManager moneyManager;

    void Update()
    {
        // 1¹ø Å° ´­·¶À» ¶§ µ· Ãß°¡
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            moneyManager.AddMoney(100); // 100¿ø Ãß°¡
            Debug.Log("µ· Ãß°¡µÊ: +100");
        }

        // 2¹ø Å° ´­·¶À» ¶§ µ· »ç¿ë
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            bool success = moneyManager.SpendMoney(50); // 50¿ø »ç¿ë
            Debug.Log(success ? "µ· »ç¿ëµÊ: -50" : "µ· ºÎÁ·ÇØ¼­ »ç¿ë ºÒ°¡");
        }
    }
}
