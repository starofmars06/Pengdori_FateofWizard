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

    FlowerMove FM = FindObjectOfType<FlowerMove>();

    // Start is called before the first frame update
    void Start()
    {
        isMixed = false;
        acceleration = Input.acceleration;
        currentAcceleration = Input.acceleration;
        RmixPlant = PlayerPrefs.GetInt("PlantPinkNum");
        BmixPlant = PlayerPrefs.GetInt("PlantOrangeNum");
        YmixPlant = PlayerPrefs.GetInt("PlantSkyblueNum");
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
            PlayerPrefs.SetInt("PlayerPinkNum", RmixPlant);
            PlayerPrefs.SetInt("PlayerOrangeNum", BmixPlant);
            PlayerPrefs.SetInt("PlayerSkyblueNum", YmixPlant);
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
        if (RmixPlant == 2 && BmixPlant == 1)
        {
            SceneManager.LoadScene("07_1RedPotionCreateScene");
        }
        else if (BmixPlant == 2)
        {
            SceneManager.LoadScene("07_2YellowPotionCreateScene");
        }
        else if (RmixPlant == 1 && YmixPlant == 2)
        {
            SceneManager.LoadScene("07_3PurplePotionCreateScene");
        }
        else{
            SceneManager.LoadScene("07_4PotionFailScene");
        }
    }

}
