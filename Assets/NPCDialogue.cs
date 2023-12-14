using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogText;

    // 세 가지 기본 대화
    private string[] npcDialogs = {
        "도움말을 확인하는 것도 좋지.",
        "힘들 때는 쉬어가는 것도 미덕이야.",
        "마법약이나 만들러 갈래?"
    };

    void Start()
    {
        ShowRandomDialog();
    }

    void ShowRandomDialog()
    {
        // 랜덤으로 대화 선택
        int randomIndex = Random.Range(0, npcDialogs.Length);
        string selectedDialog = npcDialogs[randomIndex];

        // TMPro에 대화 표시
        dialogText.text = selectedDialog;
    }
}
