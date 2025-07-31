using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 하나의 방해물 효과 정의 구조
/// </summary>
public class ObstacleEffectEntry
{
    /// 효과 이름 
    public string Name;

    /// 실제 효과를 적용하는 함수
    public Func<ObstacleGameState, object, bool> Apply;

    /// 효과에 전달되는 파라미터
    public object Parameter;

    /// 발동 우선순위 (높을수록 먼저 적용)
    public int Priority;

    /// 지속 턴 수 (0이면 즉시형)
    public int Duration;

    /// 같은 효과가 중복 적용 가능한지 여부
    public bool IsStackable;

    public ObstacleEffectEntry()
    {
        Name = "";
        Parameter = new object(); // 기본값
        Priority = 0;
        Duration = 0;
        IsStackable = false;
        Apply = (state, param) => true;
    }
}
