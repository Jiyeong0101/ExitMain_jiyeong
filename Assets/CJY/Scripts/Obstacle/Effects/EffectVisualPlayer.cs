using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EffectVisualPlayer : MonoBehaviour
{
    [SerializeField] private GameObject dustEffect; //황사이펙트
    [SerializeField] private GameObject smogEffect; //안개이펙트
    [SerializeField] private GameObject rainEffect; //비이펙트
    [SerializeField] private GameObject overheatWarningUI; //다음블록 막는 UI
    [SerializeField] private TextMeshProUGUI overheatWarningText; 

    // 4,5월 황사 효과
    public void PlayDustStorm(float duration = 5f)
    {
        if (dustEffect == null) return;
        dustEffect.SetActive(true);
        StartCoroutine(HideAfterSeconds(dustEffect, duration));
    }

    // 7월 비 내리는 효과
    public void PlayRainEffect()
    {
        if (rainEffect == null) return;
        rainEffect.SetActive(true);
    }

    // 8월 폭염 효과
    public void PlayOverheatWarning(string message = "건축 기계 과열!")
    {
        if (overheatWarningUI == null || overheatWarningText == null) return;
        overheatWarningText.text = message;
        overheatWarningUI.SetActive(true);
    }

    // 11월 스모그 효과
    public void PlaySmogEffect()
    {
        if (smogEffect == null) return;
        smogEffect.SetActive(true);
    }

    private IEnumerator HideAfterSeconds(GameObject obj, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }
}

