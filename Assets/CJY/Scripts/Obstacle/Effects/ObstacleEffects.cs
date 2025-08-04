using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleEffects
{
    // 1�� : ȸ�� ���� (������ ���)
    public static void DisableRotation(ObstacleGameState state)
    {
        
    }

    // 2�� : ��� �и� (��ǳ)
    public static void PushBlockRandomly(ObstacleGameState state)
    {
    }

    // 3�� : �Է� ���� (�ܼ�)
    public static void InputDelay(ObstacleGameState state)
    {
    }

    // 4~5�� : �þ� ���� (Ȳ��)
    public static void ApplyDustStormEffect(ObstacleGameState state)
    {
        state.VisualPlayer?.PlayDustStorm(5f);
    }

    // 6�� : ���� �Ͻ� ���� (����)
    public static void DisableControlTemporary(ObstacleGameState state)
    {
    }

    // 7�� : �����̽� �Ұ���
    public static void DisableSpace(ObstacleGameState state)
    {
    }

    // 7�� : ���ϼӵ� ���� (�帶)
    public static void SlowDropSpeed(ObstacleGameState state)
    {
    }

    // 8�� : ���� ��� UI ��Ȱ��ȭ (����)
    public static void HideNextBlockUI(ObstacleGameState state)
    {
        state.VisualPlayer?.PlayOverheatWarning("���� ��� ����!");
    }

    // 10�� : ��� �ı� Ȯ�� (�Ǳ�)
    public static void BreakBlockOnPlace(ObstacleGameState state)
    {
    }

    // 11�� : ���� UI ����� ȿ�� (�����)
    public static void ApplySmogOverlay(ObstacleGameState state)
    {
        state.VisualPlayer?.PlaySmogEffect();
    }
}
