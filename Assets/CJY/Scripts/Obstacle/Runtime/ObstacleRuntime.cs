using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 실행 가능한 방해물 객체 (조건 + 효과)
/// </summary>
public class ObstacleRuntime
{
    // 조건 리스트: 해당 방해물이 발동하기 위해 모두 만족해야 하는 조건들
    public List<IObstacleCondition> Conditions { get; private set; } = new();

    // 효과 리스트: 조건을 만족했을 때 적용할 함수들
    public List<System.Action<ObstacleGameState>> Effects { get; private set; } = new();

    // 생성자
    public ObstacleRuntime(List<IObstacleCondition> conditions, List<System.Action<ObstacleGameState>> effects)
    {
        Conditions = conditions;
        Effects = effects;
    }

    // 모든 조건을 만족하는지 평가
    public bool AreConditionsMet(ObstacleGameState state)
    {
        foreach (var cond in Conditions)
        {
            if (!cond.Evaluate(state))
                return false;
        }
        return true;
    }

    // 조건이 만족되면 효과를 실행
    public void ExecuteEffects(ObstacleGameState state)
    {
        foreach (var effect in Effects)
        {
            effect(state);
        }
    }
}
