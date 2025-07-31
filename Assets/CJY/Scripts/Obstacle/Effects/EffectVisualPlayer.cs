using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectVisualPlayer : MonoBehaviour
{
    public static void Play(string effectName, object param)
    {
        switch (effectName)
        {
            case "DisableRotation":
                //예시
                //UIEffect.ShowText("회전 금지!", Color.red);
                break;

            default:
                Debug.LogWarning($"정의되지 않은 효과 연출: {effectName}");
                break;
        }
    }
}
