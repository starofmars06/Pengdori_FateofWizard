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
        //1. 약초 얻기
        // PlayerPrefs에 "LastPlantCheckDate"라는 키로 마지막 약초 상호작용 날짜 기록
        string lastPlantDate = PlayerPrefs.GetString("LastPlantCheckDate", "");

        // 오늘 날짜를 문자열로 가져오기
        string todayDate1 = DateTime.Now.ToString("yyyy-MM-dd");

        // 만약 오늘 날짜와 저장된 날짜가 다르다면 버튼을 활성화하고, 같다면 비활성화
        if (lastPlantDate != todayDate1)
        {
            plantButton.interactable = true;
        }
        else
        {
            plantButton.interactable = false;
            resultText.text = "오늘은 이미 약초를 얻었습니다.";
        }


        //2. 마법 전투
        string lastFightDate = PlayerPrefs.GetString("LastFightCheckDate", "");

        // 오늘 날짜를 문자열로 가져오기
        string todayDate2 = DateTime.Now.ToString("yyyy-MM-dd");

        // 만약 오늘 날짜와 저장된 날짜가 다르다면 버튼을 활성화하고, 같다면 비활성화
        if (lastFightDate != todayDate2)
        {
            fightButton.interactable = true;
        }
        else
        {
            fightButton.interactable = false;
            resultText.text = "오늘은 이미 전투를 진행했습니다.";
        }

    }


}
