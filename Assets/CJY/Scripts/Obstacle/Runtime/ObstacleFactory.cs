using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFactory
{
    public List<ObstacleRuntime> CreateAllObstacles()
    {
        var obstacles = new List<ObstacleRuntime>();

        // 1�� - ȸ�� ����
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(1) },
            new List<ObstacleEffectEntry> { ObstacleEffectMap.EffectTable["DisableRotation"] }
        ));

        // 2�� - ��� �и� (�⺻ ��������)
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(2) },
            new List<ObstacleEffectEntry> { ObstacleEffectMap.EffectTable["PushBlockRandomly"] }
        ));

        // 3�� - �Է� ����
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(3) },
            new List<ObstacleEffectEntry> { ObstacleEffectMap.EffectTable["InputDelay"] }
        ));

        // 4~5�� - Ȳ�� �þ� ����
        for (int month = 4; month <= 5; month++)
        {
            obstacles.Add(new ObstacleRuntime(
                new List<IObstacleCondition> { new Condition_Time(month) },
                new List<ObstacleEffectEntry> { ObstacleEffectMap.EffectTable["ApplyDustStormEffect"] }
            ));
        }

        // 6�� - ���� �Ͻ� ����
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(6) },
            new List<ObstacleEffectEntry> { ObstacleEffectMap.EffectTable["DisableControlTemporary"] }
        ));

        // 7�� - �����̽� ���� + ���� �ӵ� ����
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(7) },
            new List<ObstacleEffectEntry> {
                ObstacleEffectMap.EffectTable["DisableSpace"],
                ObstacleEffectMap.EffectTable["SlowDropSpeed"]
            }
        ));

        // 8�� - ���� ��� UI �����
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(8) },
            new List<ObstacleEffectEntry> { ObstacleEffectMap.EffectTable["HideNextBlockUI"] }
        ));

        // 10�� - ��� �ı� Ȯ��
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(10) },
            new List<ObstacleEffectEntry> { ObstacleEffectMap.EffectTable["BreakBlockOnPlace"] }
        ));

        // 11�� - UI ����� ��������
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(11) },
            new List<ObstacleEffectEntry> { ObstacleEffectMap.EffectTable["ApplySmogOverlay"] }
        ));

        // �ʿ� ��: ��Ÿ Ŀ���� ���� ���ع��� �߰� ����

        return obstacles;
    }
}
