using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SwitchToMagicPlantScene()
    {
        SceneManager.LoadScene("Plant_temp");
    }

    public void SwitchToMagicPotionScene()
    {
        SceneManager.LoadScene("Potion_temp");
    }

    public void SwitchToMagicFightScene()
    {
        SceneManager.LoadScene("Fight_Test");
    }
}
