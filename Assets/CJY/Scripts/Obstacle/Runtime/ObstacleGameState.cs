using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ع� ���� �� �� ȿ�� ������ ���� �ּ����� ���� ���� ����
/// </summary>
public class ObstacleGameState
{
    public int CurrentMonth { get; set; } = 1;

    public bool CanRotate { get; set; } = true;
    public bool CanHardDrop { get; set; } = true;
    public bool NextBlockVisible { get; set; } = true;

    public float InputDelay { get; set; } = 0f;
    public float DropSpeedMultiplier { get; set; } = 1f;
    public float DisableControlTime { get; set; } = 0f;
    public float BlockBreakChance { get; set; } = 0f;
    public float SmogLevel { get; set; } = 0f;

    public string PushDirection { get; set; } = null;
    public string FogType { get; set; } = null;
}
