using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ع� �ߵ� ���� �������̽�
/// </summary>
public interface IObstacleCondition
{
    bool Evaluate(ObstacleGameState state);
}
