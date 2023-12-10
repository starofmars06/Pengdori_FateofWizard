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

    //�յ��� Ʃ�丮��
    //�ٽ� ���ư���
    public void goBackto_BeforeScene()
    {
        int sceneNum = PlayerPrefs.GetInt("HandTutorial");

        if(sceneNum == 0)
        {
            //�Ϲ� ���� ������ ���ư���
            SceneManager.LoadScene("08_1Fight_Test");
        }
        else if(sceneNum == 1)
        {
            //���� ���� ������ ���ư���
            SceneManager.LoadScene("09_1HandTracking_Test");
        }
        else if(sceneNum == 2)
        {
            //���� ���� ���� ������ ���ư���
            SceneManager.LoadScene("11_2FinalBoss");
        }
        else if (sceneNum == 3)
        {
            //Ʃ�丮�� ���� ������ ���ư���
            SceneManager.LoadScene("04_2Tutorials");
        }
    }

    //�Ϲ� ���� --> ����
    public void gotoHandTutorial_fromBattle()
    {
        int handTutorial = PlayerPrefs.GetInt("HandTutorial");
        handTutorial = 0;
        Debug.Log("�Ѿ�� �� ��ȣ(0�̸� ����, 1�̸� ����, 2�� ��������) :" + handTutorial);
        PlayerPrefs.SetInt("HandTutorial", handTutorial);

        SceneManager.LoadScene("09_2HandTracking_Tutorial");
    }

    //���� ���� --> ����
    public void gotoHandTutorial_fromPractice()
    {
        int handTutorial = PlayerPrefs.GetInt("HandTutorial");
        handTutorial = 1;
        Debug.Log("�Ѿ�� �� ��ȣ(0�̸� ����, 1�̸� ����, 2�� ��������) :" + handTutorial);
        PlayerPrefs.SetInt("HandTutorial", handTutorial);

        SceneManager.LoadScene("09_2HandTracking_Tutorial");
    }

    //�������� --> ����
    public void gotoHandTutorial_fromFinalBoss()
    {
        int handTutorial = PlayerPrefs.GetInt("HandTutorial");
        handTutorial = 2;
        Debug.Log("�Ѿ�� �� ��ȣ(0�̸� ����, 1�̸� ����, 2�� ��������) :" + handTutorial);
        PlayerPrefs.SetInt("HandTutorial", handTutorial);

        SceneManager.LoadScene("09_2HandTracking_Tutorial");
    }

    //Ʃ�丮�� ã�� --> ����
    public void gotoHandTutorial_fromTutorialSearch()
    {
        int handTutorial = PlayerPrefs.GetInt("HandTutorial");
        handTutorial = 3;
        Debug.Log("�Ѿ�� �� ��ȣ(0�̸� ����, 1�̸� ����, 2�� ��������) :" + handTutorial);
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

    //Plant ���� ���� ��ȯ
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
