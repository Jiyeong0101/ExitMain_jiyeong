using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 이름으로 매핑된 방해물 효과 정의 테이블
/// </summary>
public static class ObstacleEffectMap
{
    public static Dictionary<string, ObstacleEffectEntry> EffectTable = new()
    {
        // 1월 : 회전 금지 (얼어붙은 블록)
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

        // 2월 : 블록 밀림 (강풍)
        {
            "PushBlockRandomly",
            new ObstacleEffectEntry {
                Name = "PushBlockRandomly",
                Apply = (state, param) => {
                    state.PushDirection = (string)param; // "Left" 또는 "Right"
                    return true;
                },
                Parameter = "Left", // 기본값
                Priority = 8,
                Duration = 0,
                IsStackable = false
            }
        },

        // 3월 : 입력 지연 (잔설)
        {
            "InputDelay",
            new ObstacleEffectEntry {
                Name = "InputDelay",
                Apply = (state, param) => {
                    state.InputDelay = (float)param;
                    return true;
                },
                Parameter = 0.5f, // 0.5초 지연
                Priority = 6,
                Duration = 0,
                IsStackable = false
            }
        },

        // 4~5월 : 시야 차단 (황사)
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

        // 6월 : 조작 일시 정지 (낙뢰)
        {
            "DisableControlTemporary",
            new ObstacleEffectEntry {
                Name = "DisableControlTemporary",
                Apply = (state, param) => {
                    state.DisableControlTime = (float)param;
                    return true;
                },
                Parameter = 1.0f, // 1초 동안 조작 불가
                Priority = 9,
                Duration = 0,
                IsStackable = false
            }
        },

        // 7월 : 스페이스 불가능 + 낙하속도 저하 (장마)
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
                Parameter = 0.7f, // 70% 속도로 느리게
                Priority = 5,
                Duration = 0,
                IsStackable = true
            }
        },

        // 8월 : 다음 블록 UI 비활성화 (폭염)
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

        // 10월 : 블록 파괴 확률 (건기)
        {
            "BreakBlockOnPlace",
            new ObstacleEffectEntry {
                Name = "BreakBlockOnPlace",
                Apply = (state, param) => {
                    state.BlockBreakChance = (float)param;
                    return true;
                },
                Parameter = 0.05f, // 5% 확률로 블록 파괴
                Priority = 4,
                Duration = 0,
                IsStackable = false
            }
        },

        // 11월 : 정보 UI 스모그 효과 (스모그)
        {
            "ApplySmogOverlay",
            new ObstacleEffectEntry {
                Name = "ApplySmogOverlay",
                Apply = (state, param) => {
                    state.SmogLevel = 1.0f; // 스모그 강도
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

