using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public float timeRemaining = 30f; // 시작 타이머 값

    void Start()
    {
        UpdateTimerUI();
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // 시간 감소
            UpdateTimerUI();
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "08_1Fight_Test") 
            {
                // 시간이 다 떨어졌을 때 재도전 씬으로 전환
                SceneManager.LoadScene("13_1Restart");
            }
            else
            {
                //최종 전투에서는 게임 오버 씬으로 전환
                SceneManager.LoadScene("13_2GameOver");
            }
            
        }
    }

    void UpdateTimerUI()
    {
        int seconds = Mathf.RoundToInt(timeRemaining);
        timerText.text = "남은 시간: " + seconds.ToString() + "초";
    }
}
