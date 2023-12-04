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
        SceneManager.LoadScene("06_0Plant");
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
}
