using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CauldronManager : MonoBehaviour
{
    private float shakeThreshold1 = 6.5f;

    private Vector3 acceleration;
    private Vector3 currentAcceleration;
    private Vector3 deltaAcceleration;

    private bool isMixed;

    public int Rinit;
    public int Binit;
    public int Yinit;

    public int RmixPlant = 0;
    public int BmixPlant = 0;
    public int YmixPlant = 0;

    private FlowerMove FM;

    private int magicPowerNum;
    private int magicPowerGet;

    // Start is called before the first frame update
    void Start()
    {
        isMixed = false;
        acceleration = Input.acceleration;
        currentAcceleration = Input.acceleration;
        Rinit = PlayerPrefs.GetInt("PlantPinkNum");
        Binit = PlayerPrefs.GetInt("PlantOrangeNum");
        Yinit = PlayerPrefs.GetInt("PlantSkyblueNum");

        RmixPlant = 0;
        BmixPlant = 0;
        YmixPlant = 0;

        FM = FindObjectOfType<FlowerMove>();
        FM.count = 0;
    }

    // Update is called once per frame
    void Update()
    {

        currentAcceleration = Input.acceleration;

        deltaAcceleration = currentAcceleration - acceleration;

        if (deltaAcceleration.sqrMagnitude >= shakeThreshold1 * shakeThreshold1)
        {
            Mix();
            isMixed = true;
        }
        acceleration = currentAcceleration;

        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("07_0PotionScene") && isMixed == false){
            PlayerPrefs.SetInt("PlayerPinkNum", Rinit);
            PlayerPrefs.SetInt("PlayerOrangeNum", Binit);
            PlayerPrefs.SetInt("PlayerSkyblueNum", Yinit);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("RedCube"))
        {
            int pn = PlayerPrefs.GetInt("PlantPinkNum");
            pn--;
            PlayerPrefs.SetInt("PlantPinkNum", pn);
            RmixPlant++;
            FM.count++;
        }
        else if (other.CompareTag("BlueCube"))
        {
            int on = PlayerPrefs.GetInt("PlantOrangeNum");
            on--;
            PlayerPrefs.SetInt("PlantOrangeNum", on);
            BmixPlant++;
            FM.count++;
        }
        else if (other.CompareTag("YellowCube"))
        {
            int sn = PlayerPrefs.GetInt("PlantSkyblueNum");
            sn--;
            PlayerPrefs.SetInt("PlantSkyblueNum", sn);
            YmixPlant++;
            FM.count++;
        }
        other.gameObject.SetActive(false);
    }

    void Mix()
    {
        FM.count = 0;
        if (RmixPlant == 2 && BmixPlant == 1)
        {
            PlayerPrefs.SetInt("Potion1", PlayerPrefs.GetInt("Potion1") + 1);
            magicPowerGet = 10;
            PlayerPrefs.SetInt("MagicPowerGet", magicPowerGet);
            magicPowerNum = PlayerPrefs.GetInt("MagicPower");
            PlayerPrefs.SetInt("MagicPower", magicPowerNum + magicPowerGet);
            SceneManager.LoadScene("07_1RedPotionCreateScene");
        }
        else if (BmixPlant == 2)
        {
            PlayerPrefs.SetInt("Potion2", PlayerPrefs.GetInt("Potion2") + 1);
            magicPowerGet = 10;
            PlayerPrefs.SetInt("MagicPowerGet", magicPowerGet);
            magicPowerNum = PlayerPrefs.GetInt("MagicPower");
            PlayerPrefs.SetInt("MagicPower", magicPowerNum + magicPowerGet);
            SceneManager.LoadScene("07_2YellowPotionCreateScene");
        }
        else if (RmixPlant == 1 && YmixPlant == 2)
        {
            PlayerPrefs.SetInt("Potion3", PlayerPrefs.GetInt("Potion3") + 1);
            magicPowerGet = 10;
            PlayerPrefs.SetInt("MagicPowerGet", magicPowerGet);
            magicPowerNum = PlayerPrefs.GetInt("MagicPower");
            PlayerPrefs.SetInt("MagicPower", magicPowerNum + magicPowerGet);
            SceneManager.LoadScene("07_3PurplePotionCreateScene");
        }
        else{
            SceneManager.LoadScene("07_4PotionFailScene");
        }
    }

}
