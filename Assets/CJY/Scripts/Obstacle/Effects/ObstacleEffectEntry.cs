using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// �ϳ��� ���ع� ȿ�� ���� ����
/// </summary>
public class ObstacleEffectEntry
{
    /// ȿ�� �̸� 
    public string Name;

    /// ���� ȿ���� �����ϴ� �Լ�
    public Func<ObstacleGameState, object, bool> Apply;

    /// ȿ���� ���޵Ǵ� �Ķ����
    public object Parameter;

    /// �ߵ� �켱���� (�������� ���� ����)
    public int Priority;

    /// ���� �� �� (0�̸� �����)
    public int Duration;

    /// ���� ȿ���� �ߺ� ���� �������� ����
    public bool IsStackable;

    public ObstacleEffectEntry()
    {
        Name = "";
        Parameter = new object(); // �⺻��
        Priority = 0;
        Duration = 0;
        IsStackable = false;
        Apply = (state, param) => true;
    }
}
