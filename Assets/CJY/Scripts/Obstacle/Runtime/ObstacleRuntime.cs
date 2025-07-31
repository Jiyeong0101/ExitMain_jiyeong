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

    // 효과 리스트: 조건을 만족했을 때 적용할 효과들의 리스트
    public List<ObstacleEffectEntry> Effects { get; private set; } = new();

    // 현재 적용된 효과들의 이름을 추적하는 집합 (중복 실행 방지용)
    private HashSet<string> activeEffects = new();

    // 생성자: 조건과 효과를 받아 초기화
    public ObstacleRuntime(List<IObstacleCondition> conditions, List<ObstacleEffectEntry> effects)
    {
        Conditions = conditions;
        Effects = effects;
    }

    // 모든 조건이 만족되는지 평가하는 메서드
    public bool AreConditionsMet(ObstacleGameState state)
    {
        foreach (var cond in Conditions)          // 모든 조건에 대해
        {
            if (!cond.Evaluate(state))            // 하나라도 false를 반환하면
                return false;                     // 조건 불충족 → false 반환
        }
        return true;                              // 모든 조건을 만족하면 true 반환
    }

    // 효과를 실행하는 메서드
    public void ExecuteEffects(ObstacleGameState state)
    {
        foreach (var effect in Effects)                       // 모든 효과에 대해 순회
        {
            if (!effect.IsStackable && activeEffects.Contains(effect.Name))
                continue;                                     // 중복 허용되지 않으며 이미 실행된 경우 무시

            bool success = effect.Apply(state, effect.Parameter); // 효과 적용 함수 실행
            if (success)                                      // 성공적으로 적용되었다면
            {
                activeEffects.Add(effect.Name);              // 실행 중인 효과 목록에 추가
                EffectVisualPlayer.Play(effect.Name, effect.Parameter); // 시각적 연출 실행
            }
        }
    }

    // 특정 효과를 해제하는 메서드 (필요 시 외부에서 수동 해제)
    public void ClearEffect(string effectName)
    {
        activeEffects.Remove(effectName);         // 해당 효과 이름을 실행 중 목록에서 제거
    }
}
