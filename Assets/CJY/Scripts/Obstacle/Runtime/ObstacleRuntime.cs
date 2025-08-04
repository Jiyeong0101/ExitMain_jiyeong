using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� ������ ���ع� ��ü (���� + ȿ��)
/// </summary>
public class ObstacleRuntime
{
    // ���� ����Ʈ: �ش� ���ع��� �ߵ��ϱ� ���� ��� �����ؾ� �ϴ� ���ǵ�
    public List<IObstacleCondition> Conditions { get; private set; } = new();

    // ȿ�� ����Ʈ: ������ �������� �� ������ �Լ���
    public List<System.Action<ObstacleGameState>> Effects { get; private set; } = new();

    // ������
    public ObstacleRuntime(List<IObstacleCondition> conditions, List<System.Action<ObstacleGameState>> effects)
    {
        Conditions = conditions;
        Effects = effects;
    }

    // ��� ������ �����ϴ��� ��
    public bool AreConditionsMet(ObstacleGameState state)
    {
        foreach (var cond in Conditions)
        {
            if (!cond.Evaluate(state))
                return false;
        }
        return true;
    }

    // ������ �����Ǹ� ȿ���� ����
    public void ExecuteEffects(ObstacleGameState state)
    {
        foreach (var effect in Effects)
        {
            effect(state);
        }
    }
}
