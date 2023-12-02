using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SwitchToLobby()
    {
        SceneManager.LoadScene("05Lobby");
    }

    public void SwitchToMagicPlantScene()
    {
        SceneManager.LoadScene("Plant_temp");
    }

    public void SwitchToMagicPotionScene()
    {
        SceneManager.LoadScene("PotionScene");
    }

    public void SwitchToMagicFightScene()
    {
        SceneManager.LoadScene("Fight_Test");
    }

    public void SwitchToMagicPracticeScene()
    {
        SceneManager.LoadScene("HandTracking_Test");
    }
}
