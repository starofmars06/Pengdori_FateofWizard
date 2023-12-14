using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogText;

    // �� ���� �⺻ ��ȭ
    private string[] npcDialogs = {
        "������ Ȯ���ϴ� �͵� ����.",
        "���� ���� ����� �͵� �̴��̾�.",
        "�������̳� ���鷯 ����?"
    };

    void Start()
    {
        ShowRandomDialog();
    }

    void ShowRandomDialog()
    {
        // �������� ��ȭ ����
        int randomIndex = Random.Range(0, npcDialogs.Length);
        string selectedDialog = npcDialogs[randomIndex];

        // TMPro�� ��ȭ ǥ��
        dialogText.text = selectedDialog;
    }
}
