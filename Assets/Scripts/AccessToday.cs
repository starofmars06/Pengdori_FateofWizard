using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using TMPro;

public class AccessToday : MonoBehaviour
{
    public Button plantButton;
    public Button fightButton;

    public Text resultText;

    void Start()
    {
        //1. ���� ���
        // PlayerPrefs�� "LastPlantCheckDate"��� Ű�� ������ ���� ��ȣ�ۿ� ��¥ ���
        string lastPlantDate = PlayerPrefs.GetString("LastPlantCheckDate", "");

        // ���� ��¥�� ���ڿ��� ��������
        string todayDate1 = DateTime.Now.ToString("yyyy-MM-dd");

        // ���� ���� ��¥�� ����� ��¥�� �ٸ��ٸ� ��ư�� Ȱ��ȭ�ϰ�, ���ٸ� ��Ȱ��ȭ
        if (lastPlantDate != todayDate1)
        {
            plantButton.interactable = true;
        }
        else
        {
            plantButton.interactable = false;
            resultText.text = "������ �̹� ���ʸ� ������ϴ�.";
        }


        //2. ���� ����
        string lastFightDate = PlayerPrefs.GetString("LastFightCheckDate", "");

        // ���� ��¥�� ���ڿ��� ��������
        string todayDate2 = DateTime.Now.ToString("yyyy-MM-dd");

        // ���� ���� ��¥�� ����� ��¥�� �ٸ��ٸ� ��ư�� Ȱ��ȭ�ϰ�, ���ٸ� ��Ȱ��ȭ
        if (lastFightDate != todayDate2)
        {
            fightButton.interactable = true;
        }
        else
        {
            fightButton.interactable = false;
            resultText.text = "������ �̹� ������ �����߽��ϴ�.";
        }

    }


}
