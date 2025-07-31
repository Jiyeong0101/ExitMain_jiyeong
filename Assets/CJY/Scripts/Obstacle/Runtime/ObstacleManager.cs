using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 모든 방해물 조건평가 및 효과적용 컨트롤러
/// </summary>
public class ObstacleManager
{
    // 현재 관리 중인 모든 런타임 방해물 목록
    private List<ObstacleRuntime> obstacles = new();

    /// <summary>
    /// 팩토리에서 생성된 방해물들을 한 번에 초기화
    /// </summary>
    public void Initialize(List<ObstacleRuntime> obstacleList)
    {
        obstacles = obstacleList;
    }

    /// <summary>
    /// 게임 상태를 받아 조건 검사 & 효과 실행
    /// </summary>
    public void Update(ObstacleGameState state)
    {
        foreach (var obstacle in obstacles)
        {
            if (obstacle.AreConditionsMet(state))
            {
                obstacle.ExecuteEffects(state);
            }
        }
    }
}
