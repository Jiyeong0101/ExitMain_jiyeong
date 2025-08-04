using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ع� ���� �� �� ȿ�� ������ ���� �ּ����� ���� ���� ����
/// </summary>
public class ObstacleGameState
{
    public EffectVisualPlayer VisualPlayer;
    public InputBlocker InputBlocker;

    public ObstacleGameState(EffectVisualPlayer visualPlayer, InputBlocker inputBlocker)
    {
        VisualPlayer = visualPlayer;
        InputBlocker = inputBlocker;
    }

    public int CurrentMonth { get; set; } = 1;

}
