using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �̸����� ���ε� ���ع� ȿ�� ���� ���̺�
/// </summary>
public static class ObstacleEffectMap
{
    public static Dictionary<string, ObstacleEffectEntry> EffectTable = new()
    {
        // 1�� : ȸ�� ���� (������ ���)
        {
            "DisableRotation",
            new ObstacleEffectEntry {
                Name = "DisableRotation",
                Apply = (state, param) => {
                    state.CanRotate = false;
                    return true;
                },
                Parameter = null,
                Priority = 10,
                Duration = 0,
                IsStackable = false
            }
        },

        // 2�� : ��� �и� (��ǳ)
        {
            "PushBlockRandomly",
            new ObstacleEffectEntry {
                Name = "PushBlockRandomly",
                Apply = (state, param) => {
                    state.PushDirection = (string)param; // "Left" �Ǵ� "Right"
                    return true;
                },
                Parameter = "Left", // �⺻��
                Priority = 8,
                Duration = 0,
                IsStackable = false
            }
        },

        // 3�� : �Է� ���� (�ܼ�)
        {
            "InputDelay",
            new ObstacleEffectEntry {
                Name = "InputDelay",
                Apply = (state, param) => {
                    state.InputDelay = (float)param;
                    return true;
                },
                Parameter = 0.5f, // 0.5�� ����
                Priority = 6,
                Duration = 0,
                IsStackable = false
            }
        },

        // 4~5�� : �þ� ���� (Ȳ��)
        {
            "ApplyDustStormEffect",
            new ObstacleEffectEntry {
                Name = "ApplyDustStormEffect",
                Apply = (state, param) => {
                    state.FogType = "DustStorm";
                    return true;
                },
                Parameter = null,
                Priority = 7,
                Duration = 0,
                IsStackable = false
            }
        },

        // 6�� : ���� �Ͻ� ���� (����)
        {
            "DisableControlTemporary",
            new ObstacleEffectEntry {
                Name = "DisableControlTemporary",
                Apply = (state, param) => {
                    state.DisableControlTime = (float)param;
                    return true;
                },
                Parameter = 1.0f, // 1�� ���� ���� �Ұ�
                Priority = 9,
                Duration = 0,
                IsStackable = false
            }
        },

        // 7�� : �����̽� �Ұ��� + ���ϼӵ� ���� (�帶)
        {
            "DisableSpace",
            new ObstacleEffectEntry {
                Name = "DisableSpace",
                Apply = (state, param) => {
                    state.CanHardDrop = false;
                    return true;
                },
                Parameter = null,
                Priority = 9,
                Duration = 0,
                IsStackable = false
            }
        },
        {
            "SlowDropSpeed",
            new ObstacleEffectEntry {
                Name = "SlowDropSpeed",
                Apply = (state, param) => {
                    state.DropSpeedMultiplier *= (float)param;
                    return true;
                },
                Parameter = 0.7f, // 70% �ӵ��� ������
                Priority = 5,
                Duration = 0,
                IsStackable = true
            }
        },

        // 8�� : ���� ��� UI ��Ȱ��ȭ (����)
        {
            "HideNextBlockUI",
            new ObstacleEffectEntry {
                Name = "HideNextBlockUI",
                Apply = (state, param) => {
                    state.NextBlockVisible = false;
                    return true;
                },
                Parameter = null,
                Priority = 10,
                Duration = 0,
                IsStackable = false
            }
        },

        // 10�� : ��� �ı� Ȯ�� (�Ǳ�)
        {
            "BreakBlockOnPlace",
            new ObstacleEffectEntry {
                Name = "BreakBlockOnPlace",
                Apply = (state, param) => {
                    state.BlockBreakChance = (float)param;
                    return true;
                },
                Parameter = 0.05f, // 5% Ȯ���� ��� �ı�
                Priority = 4,
                Duration = 0,
                IsStackable = false
            }
        },

        // 11�� : ���� UI ����� ȿ�� (�����)
        {
            "ApplySmogOverlay",
            new ObstacleEffectEntry {
                Name = "ApplySmogOverlay",
                Apply = (state, param) => {
                    state.SmogLevel = 1.0f; // ����� ����
                    return true;
                },
                Parameter = null,
                Priority = 3,
                Duration = 0,
                IsStackable = false
            }
        }
    };
}

