using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputBlocker : MonoBehaviour
{
    private bool spaceBlocked = false;

    public void EnableSpaceBlock() => spaceBlocked = true;
    public void DisableSpaceBlock() => spaceBlocked = false;

    // �츮�� ����ϴ� ��¥ �����̽� �Է� �̺�Ʈ
    public event Action OnSpaceFiltered;

    // InputManager�� ����
    public void Hook()
    {
        //InputManager.Instance.OnSpace += HandleSpace;
    }

    public void Unhook()
    {
        //InputManager.Instance.OnSpace -= HandleSpace;
    }

    private void HandleSpace()
    {
        if (!spaceBlocked)
        {
            OnSpaceFiltered?.Invoke();  // ������ ������� ���� ����
        }
        else
        {
            Debug.Log("[InputBlocker] �����̽� �Է��� ���ܵǾ����ϴ�.");
        }
    }
}
