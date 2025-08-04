using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputBlocker : MonoBehaviour
{
    private bool spaceBlocked = false;

    public void EnableSpaceBlock() => spaceBlocked = true;
    public void DisableSpaceBlock() => spaceBlocked = false;

    // 우리가 사용하는 진짜 스페이스 입력 이벤트
    public event Action OnSpaceFiltered;

    // InputManager에 연결
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
            OnSpaceFiltered?.Invoke();  // 조건을 통과했을 때만 실행
        }
        else
        {
            Debug.Log("[InputBlocker] 스페이스 입력이 차단되었습니다.");
        }
    }
}
