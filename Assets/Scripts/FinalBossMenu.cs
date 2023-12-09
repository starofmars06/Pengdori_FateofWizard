using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalBossMenu : MonoBehaviour
{
    private int magicPowerAll;

    void Start()
    {
        magicPowerAll = PlayerPrefs.GetInt("MagicPower");
    }

    public void gotoFinalBossScene()
    {
        if (magicPowerAll >= 500)
        {
            SceneManager.LoadScene("11_1Final Boss Dialogue");
        }
        else
        {
            SceneManager.LoadScene("11_0Final Boss Yet");
        }
    }
}
