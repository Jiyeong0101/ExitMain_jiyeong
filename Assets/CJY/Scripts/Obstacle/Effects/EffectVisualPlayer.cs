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
                //����
                //UIEffect.ShowText("ȸ�� ����!", Color.red);
                break;

            default:
                Debug.LogWarning($"���ǵ��� ���� ȿ�� ����: {effectName}");
                break;
        }
    }
}
