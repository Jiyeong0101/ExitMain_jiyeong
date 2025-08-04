using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 이름으로 매핑된 방해물 효과 정의 테이블
/// </summary>
public static class ObstacleEffectMap
{
    public static readonly Dictionary<string, Action<ObstacleGameState>> EffectTable = new()
    {
        // 1월 : 회전 금지 (얼어붙은 블록)
        { "DisableRotation", ObstacleEffects.DisableRotation },
        // 2월 : 블록 밀림 (강풍)
        { "PushBlockRandomly", ObstacleEffects.PushBlockRandomly },
        // 3월 : 입력 지연 (잔설)
        { "InputDelay", ObstacleEffects.InputDelay },
        // 4~5월 : 시야 차단 (황사)
        { "ApplyDustStormEffect", ObstacleEffects.ApplyDustStormEffect },
        // 6월 : 조작 일시 정지 (낙뢰)
        { "DisableControlTemporary", ObstacleEffects.DisableControlTemporary},
        // 7월 : 스페이스 불가능 + 낙하속도 저하 (장마)
        { "DisableSpace" , ObstacleEffects.DisableSpace },
        { "SlowDropSpeed", ObstacleEffects.SlowDropSpeed },
        // 8월 : 다음 블록 UI 비활성화 (폭염)
        { "HideNextBlockUI" , ObstacleEffects.HideNextBlockUI },
        // 10월 : 블록 파괴 확률 (건기)
        {"BreakBlockOnPlace" , ObstacleEffects.BreakBlockOnPlace },
        // 11월 : 정보 UI 스모그 효과 (스모그)
        {"ApplySmogOverlay" , ObstacleEffects.ApplySmogOverlay}

        // 여기에 추가
    };

}

