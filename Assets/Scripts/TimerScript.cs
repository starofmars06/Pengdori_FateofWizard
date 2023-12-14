using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public float timeRemaining = 30f; // ���� Ÿ�̸� ��

    void Start()
    {
        UpdateTimerUI();
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // �ð� ����
            UpdateTimerUI();
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "08_1Fight_Test") 
            {
                // �ð��� �� �������� �� �絵�� ������ ��ȯ
                SceneManager.LoadScene("13_1Restart");
            }
            else
            {
                //���� ���������� ���� ���� ������ ��ȯ
                SceneManager.LoadScene("13_2GameOver");
            }
            
        }
    }

    void UpdateTimerUI()
    {
        int seconds = Mathf.RoundToInt(timeRemaining);
        timerText.text = "���� �ð�: " + seconds.ToString() + "��";
    }
}
