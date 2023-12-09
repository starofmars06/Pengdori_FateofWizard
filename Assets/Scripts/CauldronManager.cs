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

    public int RmixPlant = 0;
    public int BmixPlant = 0;
    public int YmixPlant = 0;

    // Start is called before the first frame update
    void Start()
    {
        acceleration = Input.acceleration;
        currentAcceleration = Input.acceleration;
    }

    // Update is called once per frame
    void Update()
    {
        
        currentAcceleration = Input.acceleration;

        deltaAcceleration = currentAcceleration - acceleration;

        if (deltaAcceleration.sqrMagnitude >= shakeThreshold1 * shakeThreshold1)
        {
            Mix();
        }
        acceleration = currentAcceleration;
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("RedCube"))
        {
            int pn = PlayerPrefs.GetInt("PlantPinkNum");
            pn--;
            PlayerPrefs.SetInt("PlantPinkNum", pn);
            RmixPlant++;
        }
        else if (other.CompareTag("BlueCube"))
        {
            int on = PlayerPrefs.GetInt("PlantOrangeNum");
            on--;
            PlayerPrefs.SetInt("PlantOrangeNum", on);
            BmixPlant++;
        }
        else if (other.CompareTag("YellowCube"))
        {
            int sn = PlayerPrefs.GetInt("PlantSkyblueNum");
            sn--;
            PlayerPrefs.SetInt("PlantSkyblueNum", sn);
            YmixPlant++;
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
