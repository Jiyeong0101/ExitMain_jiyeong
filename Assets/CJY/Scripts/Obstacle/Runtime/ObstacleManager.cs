using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��� ���ع� ������ �� ȿ������ ��Ʈ�ѷ�
/// </summary>
public class ObstacleManager
{
    // ���� ���� ���� ��� ��Ÿ�� ���ع� ���
    private List<ObstacleRuntime> obstacles = new();

    /// <summary>
    /// ���丮���� ������ ���ع����� �� ���� �ʱ�ȭ
    /// </summary>
    public void Initialize(List<ObstacleRuntime> obstacleList)
    {
        obstacles = obstacleList;
    }

    /// <summary>
    /// ���� ���¸� �޾� ���� �˻� & ȿ�� ����
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
