using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EffectVisualPlayer : MonoBehaviour
{
    [SerializeField] private GameObject dustEffect; //Ȳ������Ʈ
    [SerializeField] private GameObject smogEffect; //�Ȱ�����Ʈ
    [SerializeField] private GameObject rainEffect; //������Ʈ
    [SerializeField] private GameObject overheatWarningUI; //������� ���� UI
    [SerializeField] private TextMeshProUGUI overheatWarningText; 

    // 4,5�� Ȳ�� ȿ��
    public void PlayDustStorm(float duration = 5f)
    {
        if (dustEffect == null) return;
        dustEffect.SetActive(true);
        StartCoroutine(HideAfterSeconds(dustEffect, duration));
    }

    // 7�� �� ������ ȿ��
    public void PlayRainEffect()
    {
        if (rainEffect == null) return;
        rainEffect.SetActive(true);
    }

    // 8�� ���� ȿ��
    public void PlayOverheatWarning(string message = "���� ��� ����!")
    {
        if (overheatWarningUI == null || overheatWarningText == null) return;
        overheatWarningText.text = message;
        overheatWarningUI.SetActive(true);
    }

    // 11�� ����� ȿ��
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

