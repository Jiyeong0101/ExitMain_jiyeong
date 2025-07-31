using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition_Time : IObstacleCondition
{
    private int targetMonth;

    public Condition_Time(int month)
    {
        targetMonth = month;
    }

    public bool Evaluate(ObstacleGameState state)
    {
        return state.CurrentMonth == targetMonth;
    }

    //public override string ToString() => $"Time == {targetMonth}";
}

