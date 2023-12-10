using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SwitchToTutorial()
    {
        SceneManager.LoadScene("04_2Tutorials");
    }

    public void SwitchToLobby()
    {
        SceneManager.LoadScene("05Lobby");
    }

    public void SwitchToMagicPlantScene()
    {
        SceneManager.LoadScene("06_0Plant");
    }

    public void SwitchToPlantTutorial()
    {
        SceneManager.LoadScene("06_5Plant_Tutorial1");
    }

    public void SwitchToMagicPotionScene()
    {
        SceneManager.LoadScene("07_0PotionScene");
    }

    public void SwitchToMagicFightScene()
    {
        SceneManager.LoadScene("08_1Fight_Test");
    }

    public void SwitchToMagicPracticeScene()
    {
        SceneManager.LoadScene("09_1HandTracking_Test");
    }

    public void SwitchToInventoryScene()
    {
        SceneManager.LoadScene("10Inventory");
    }

    public void SwitchToFinalBossScene()
    {
        SceneManager.LoadScene("11_1Final Boss Dialogue");
    }

    //손동작 튜토리얼
    //다시 돌아가기
    public void goBackto_BeforeScene()
    {
        int sceneNum = PlayerPrefs.GetInt("HandTutorial");

        if(sceneNum == 0)
        {
            //일반 전투 씬으로 돌아가기
            SceneManager.LoadScene("08_1Fight_Test");
        }
        else if(sceneNum == 1)
        {
            //마법 연습 씬으로 돌아가기
            SceneManager.LoadScene("09_1HandTracking_Test");
        }
        else if(sceneNum == 2)
        {
            //최종 보스 전투 씬으로 돌아가기
            SceneManager.LoadScene("11_2FinalBoss");
        }
        else if (sceneNum == 3)
        {
            //튜토리얼 선택 씬으로 돌아가기
            SceneManager.LoadScene("04_2Tutorials");
        }
    }

    //일반 전투 --> 도움말
    public void gotoHandTutorial_fromBattle()
    {
        int handTutorial = PlayerPrefs.GetInt("HandTutorial");
        handTutorial = 0;
        Debug.Log("넘어가는 씬 번호(0이면 전투, 1이면 연습, 2면 최종보스) :" + handTutorial);
        PlayerPrefs.SetInt("HandTutorial", handTutorial);

        SceneManager.LoadScene("09_2HandTracking_Tutorial");
    }

    //마법 연습 --> 도움말
    public void gotoHandTutorial_fromPractice()
    {
        int handTutorial = PlayerPrefs.GetInt("HandTutorial");
        handTutorial = 1;
        Debug.Log("넘어가는 씬 번호(0이면 전투, 1이면 연습, 2면 최종보스) :" + handTutorial);
        PlayerPrefs.SetInt("HandTutorial", handTutorial);

        SceneManager.LoadScene("09_2HandTracking_Tutorial");
    }

    //최종보스 --> 도움말
    public void gotoHandTutorial_fromFinalBoss()
    {
        int handTutorial = PlayerPrefs.GetInt("HandTutorial");
        handTutorial = 2;
        Debug.Log("넘어가는 씬 번호(0이면 전투, 1이면 연습, 2면 최종보스) :" + handTutorial);
        PlayerPrefs.SetInt("HandTutorial", handTutorial);

        SceneManager.LoadScene("09_2HandTracking_Tutorial");
    }

    //튜토리얼 찾기 --> 도움말
    public void gotoHandTutorial_fromTutorialSearch()
    {
        int handTutorial = PlayerPrefs.GetInt("HandTutorial");
        handTutorial = 3;
        Debug.Log("넘어가는 씬 번호(0이면 전투, 1이면 연습, 2면 최종보스) :" + handTutorial);
        PlayerPrefs.SetInt("HandTutorial", handTutorial);

        SceneManager.LoadScene("09_2HandTracking_Tutorial");
    }

    public void gotoHandTutorial00()
    {
        SceneManager.LoadScene("09_2HandTracking_Tutorial");
    }

    public void gotoHandTutorial01()
    {
        SceneManager.LoadScene("09_2HandTracking_Tutorial 1");
    }

    public void gotoHandTutorial02()
    {
        SceneManager.LoadScene("09_2HandTracking_Tutorial 2");
    }

    public void gotoHandTutorial03()
    {
        SceneManager.LoadScene("09_2HandTracking_Tutorial 3");
    }

    //Plant 도움말 관련 전환
    public void gotoPlantTutorial_1()
    {
        if (SceneManager.GetActiveScene().name == "04_2Tutorials")
        {
            PlayerPrefs.SetInt("TutoV", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TutoV", 2);
        }
        SceneManager.LoadScene("06_5Plant_Tutorial1");
    }

    public void gotoPlantTutorial_2()
    {
        SceneManager.LoadScene("06_5Plant_Tutorial2");
    }

    public void gotoPlantTutorial_3()
    {
        SceneManager.LoadScene("06_5Plant_Tutorial3");
    }

    public void gotoPlantTutorial_4()
    {
        SceneManager.LoadScene("06_5Plant_Tutorial4");
    }

    public void gotoPlantTutorial_5()
    {
        SceneManager.LoadScene("06_5Plant_Tutorial5");
    }

    public void gotoPlantTutorial_6()
    {
        SceneManager.LoadScene("06_5Plant_Tutorial6");
    }

    public void gotoPlantTutorial_7()
    {
        SceneManager.LoadScene("06_5Plant_Tutorial7");
    }

    public void plantTutoBack()
    {
        int tutov = PlayerPrefs.GetInt("TutoV");

        if (tutov == 1)
        {
            SceneManager.LoadScene("04_2Tutorials");
        }
        else if (tutov == 2)
        {
            SceneManager.LoadScene("06_0Plant");
        }

        PlayerPrefs.DeleteKey("TutoV");
    }

    //
    public void potionTuto_1()
    {
        if (SceneManager.GetActiveScene().name == "04_2Tutorials")
        {
            PlayerPrefs.SetInt("TransitionValue", 1);
        }
        else
        {
            PlayerPrefs.SetInt("TransitionValue", 2);
        }
        SceneManager.LoadScene("07_5PotionTutorial1");
    }
    public void potionTuto_2()
    {
        SceneManager.LoadScene("07_5PotionTutorial2");
    }
    public void potionTuto_3()
    {
        SceneManager.LoadScene("07_5PotionTutorial3");
    }

    public void potionTutoBack()
    {
        int transitionValue = PlayerPrefs.GetInt("TransitionValue");

        if (transitionValue == 1)
        {
            SceneManager.LoadScene("04_2Tutorials");
        }
        else if (transitionValue == 2)
        {
            SceneManager.LoadScene("07_0PotionScene");
        }

        PlayerPrefs.DeleteKey("TransitionValue");

    }


}
