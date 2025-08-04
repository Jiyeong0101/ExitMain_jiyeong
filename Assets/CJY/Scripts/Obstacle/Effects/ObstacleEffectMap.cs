using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �̸����� ���ε� ���ع� ȿ�� ���� ���̺�
/// </summary>
public static class ObstacleEffectMap
{
    public static readonly Dictionary<string, Action<ObstacleGameState>> EffectTable = new()
    {
        // 1�� : ȸ�� ���� (������ ���)
        { "DisableRotation", ObstacleEffects.DisableRotation },
        // 2�� : ��� �и� (��ǳ)
        { "PushBlockRandomly", ObstacleEffects.PushBlockRandomly },
        // 3�� : �Է� ���� (�ܼ�)
        { "InputDelay", ObstacleEffects.InputDelay },
        // 4~5�� : �þ� ���� (Ȳ��)
        { "ApplyDustStormEffect", ObstacleEffects.ApplyDustStormEffect },
        // 6�� : ���� �Ͻ� ���� (����)
        { "DisableControlTemporary", ObstacleEffects.DisableControlTemporary},
        // 7�� : �����̽� �Ұ��� + ���ϼӵ� ���� (�帶)
        { "DisableSpace" , ObstacleEffects.DisableSpace },
        { "SlowDropSpeed", ObstacleEffects.SlowDropSpeed },
        // 8�� : ���� ��� UI ��Ȱ��ȭ (����)
        { "HideNextBlockUI" , ObstacleEffects.HideNextBlockUI },
        // 10�� : ��� �ı� Ȯ�� (�Ǳ�)
        {"BreakBlockOnPlace" , ObstacleEffects.BreakBlockOnPlace },
        // 11�� : ���� UI ����� ȿ�� (�����)
        {"ApplySmogOverlay" , ObstacleEffects.ApplySmogOverlay}

        // ���⿡ �߰�
    };

}

