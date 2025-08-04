using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFactory
{
    public List<ObstacleRuntime> CreateAllObstacles()
    {
        var obstacles = new List<ObstacleRuntime>();

        // 1월 - 회전 금지
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(1) },
            new List<System.Action<ObstacleGameState>> { ObstacleEffectMap.EffectTable["DisableRotation"] }
        ));

        // 2월 - 블록 밀림
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(2) },
            new List<System.Action<ObstacleGameState>> { ObstacleEffectMap.EffectTable["PushBlockRandomly"] }
        ));

        // 3월 - 입력 지연
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(3) },
            new List<System.Action<ObstacleGameState>> { ObstacleEffectMap.EffectTable["InputDelay"] }
        ));

        // 4~5월 - 황사 시야 차단
        for (int month = 4; month <= 5; month++)
        {
            obstacles.Add(new ObstacleRuntime(
                new List<IObstacleCondition> { new Condition_Time(month) },
                new List<System.Action<ObstacleGameState>> { ObstacleEffectMap.EffectTable["ApplyDustStormEffect"] }
            ));
        }

        // 6월 - 조작 일시 정지
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(6) },
            new List<System.Action<ObstacleGameState>> { ObstacleEffectMap.EffectTable["DisableControlTemporary"] }
        ));

        // 7월 - 스페이스 금지 + 낙하 속도 감소
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(7) },
            new List<System.Action<ObstacleGameState>> {
                ObstacleEffectMap.EffectTable["DisableSpace"],
                ObstacleEffectMap.EffectTable["SlowDropSpeed"]
            }
        ));

        // 8월 - 다음 블록 UI 숨기기
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(8) },
            new List<System.Action<ObstacleGameState>> { ObstacleEffectMap.EffectTable["HideNextBlockUI"] }
        ));

        // 10월 - 블록 파괴 확률
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(10) },
            new List<System.Action<ObstacleGameState>> { ObstacleEffectMap.EffectTable["BreakBlockOnPlace"] }
        ));

        // 11월 - UI 스모그 오버레이
        obstacles.Add(new ObstacleRuntime(
            new List<IObstacleCondition> { new Condition_Time(11) },
            new List<System.Action<ObstacleGameState>> { ObstacleEffectMap.EffectTable["ApplySmogOverlay"] }
        ));

        return obstacles;
    }
}
