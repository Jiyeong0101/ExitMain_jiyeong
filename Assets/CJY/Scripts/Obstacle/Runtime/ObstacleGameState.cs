using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 방해물 조건 평가 및 효과 적용을 위한 최소한의 게임 상태 정보
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
