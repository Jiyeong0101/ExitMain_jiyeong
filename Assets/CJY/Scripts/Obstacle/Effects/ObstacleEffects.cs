using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleEffects
{
    // 1월 : 회전 금지 (얼어붙은 블록)
    public static void DisableRotation(ObstacleGameState state)
    {
        
    }

    // 2월 : 블록 밀림 (강풍)
    public static void PushBlockRandomly(ObstacleGameState state)
    {
    }

    // 3월 : 입력 지연 (잔설)
    public static void InputDelay(ObstacleGameState state)
    {
    }

    // 4~5월 : 시야 차단 (황사)
    public static void ApplyDustStormEffect(ObstacleGameState state)
    {
        state.VisualPlayer?.PlayDustStorm(5f);
    }

    // 6월 : 조작 일시 정지 (낙뢰)
    public static void DisableControlTemporary(ObstacleGameState state)
    {
    }

    // 7월 : 스페이스 불가능
    public static void DisableSpace(ObstacleGameState state)
    {
    }

    // 7월 : 낙하속도 저하 (장마)
    public static void SlowDropSpeed(ObstacleGameState state)
    {
    }

    // 8월 : 다음 블록 UI 비활성화 (폭염)
    public static void HideNextBlockUI(ObstacleGameState state)
    {
        state.VisualPlayer?.PlayOverheatWarning("건축 기계 과열!");
    }

    // 10월 : 블록 파괴 확률 (건기)
    public static void BreakBlockOnPlace(ObstacleGameState state)
    {
    }

    // 11월 : 정보 UI 스모그 효과 (스모그)
    public static void ApplySmogOverlay(ObstacleGameState state)
    {
        state.VisualPlayer?.PlaySmogEffect();
    }
}
