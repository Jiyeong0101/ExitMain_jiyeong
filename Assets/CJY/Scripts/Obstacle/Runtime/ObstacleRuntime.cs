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

    // ȿ�� ����Ʈ: ������ �������� �� ������ ȿ������ ����Ʈ
    public List<ObstacleEffectEntry> Effects { get; private set; } = new();

    // ���� ����� ȿ������ �̸��� �����ϴ� ���� (�ߺ� ���� ������)
    private HashSet<string> activeEffects = new();

    // ������: ���ǰ� ȿ���� �޾� �ʱ�ȭ
    public ObstacleRuntime(List<IObstacleCondition> conditions, List<ObstacleEffectEntry> effects)
    {
        Conditions = conditions;
        Effects = effects;
    }

    // ��� ������ �����Ǵ��� ���ϴ� �޼���
    public bool AreConditionsMet(ObstacleGameState state)
    {
        foreach (var cond in Conditions)          // ��� ���ǿ� ����
        {
            if (!cond.Evaluate(state))            // �ϳ��� false�� ��ȯ�ϸ�
                return false;                     // ���� ������ �� false ��ȯ
        }
        return true;                              // ��� ������ �����ϸ� true ��ȯ
    }

    // ȿ���� �����ϴ� �޼���
    public void ExecuteEffects(ObstacleGameState state)
    {
        foreach (var effect in Effects)                       // ��� ȿ���� ���� ��ȸ
        {
            if (!effect.IsStackable && activeEffects.Contains(effect.Name))
                continue;                                     // �ߺ� ������ ������ �̹� ����� ��� ����

            bool success = effect.Apply(state, effect.Parameter); // ȿ�� ���� �Լ� ����
            if (success)                                      // ���������� ����Ǿ��ٸ�
            {
                activeEffects.Add(effect.Name);              // ���� ���� ȿ�� ��Ͽ� �߰�
                EffectVisualPlayer.Play(effect.Name, effect.Parameter); // �ð��� ���� ����
            }
        }
    }

    // Ư�� ȿ���� �����ϴ� �޼��� (�ʿ� �� �ܺο��� ���� ����)
    public void ClearEffect(string effectName)
    {
        activeEffects.Remove(effectName);         // �ش� ȿ�� �̸��� ���� �� ��Ͽ��� ����
    }
}
