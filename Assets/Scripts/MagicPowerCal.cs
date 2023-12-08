using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicPowerCal : MonoBehaviour
{
    public Text magicPowerText;
    public int magicPowerSum;
    private int level;

    void Awake()
    {
        if (!PlayerPrefs.HasKey("PlantOrangeNum")) // (이 디바이스에 PlantOrangeNum을 한번이라도 저장한 적이 있는가)의 반대
        {
            PlayerPrefs.SetInt("PlantOrangeNum", 0); // 이 디바이스에 PlantOrangeNum을 저장한 적이 없다면 0 저장
        }
        if (!PlayerPrefs.HasKey("PlantOrangeRandom"))
        {
            PlayerPrefs.SetInt("PlantOrangeRandom", 0);
        }

        if (!PlayerPrefs.HasKey("PlantSkyblueNum")) // (이 디바이스에 PlantSkyblueNum을 한번이라도 저장한 적이 있는가)의 반대
        {
            PlayerPrefs.SetInt("PlantSkyblueNum", 0); // 이 디바이스에 PlantSkyblueNum을 저장한 적이 없다면 0 저장
        }
        if (!PlayerPrefs.HasKey("PlantSkyblueRandom"))
        {
            PlayerPrefs.SetInt("PlantSkyblueRandom", 0);
        }

        if (!PlayerPrefs.HasKey("PlantPinkNum")) // (이 디바이스에 PlantPinkNum을 한번이라도 저장한 적이 있는가)의 반대
        {
            PlayerPrefs.SetInt("PlantPinkNum", 0); // 이 디바이스에 PlantPinkNum을 저장한 적이 없다면 0 저장
        }
        if (!PlayerPrefs.HasKey("PlantPinkRandom"))
        {
            PlayerPrefs.SetInt("PlantPinkRandom", 0);
        }

        if (!PlayerPrefs.HasKey("Potion1")) //magic potion
        {
            PlayerPrefs.SetInt("Potion1", 0); 
        }
        if (!PlayerPrefs.HasKey("Potion2"))
        {
            PlayerPrefs.SetInt("Potion2", 0);
        }
        if (!PlayerPrefs.HasKey("Potion3"))
        {
            PlayerPrefs.SetInt("Potion3", 0);
        }


        if (!PlayerPrefs.HasKey("MagicPower")) // (이 디바이스에 MagicPower을 한번이라도 저장한 적이 있는가)의 반대
        {
            PlayerPrefs.SetInt("MagicPower", 0); // 이 디바이스에 MagicPower을 저장한 적이 없다면 0 저장
        }
        if (!PlayerPrefs.HasKey("MagicPowerGet")) 
        {
            PlayerPrefs.SetInt("MagicPowerGet", 0); 
        }
        magicPowerText = GetComponent<Text>();
    }

    void LateUpdate()
    {
        magicPowerSum = PlayerPrefs.GetInt("MagicPower");

        level = magicPowerSum / 100;
        level = level + 1;

        magicPowerText.text = "Magic Power : " + magicPowerSum + "[ " + level + " Lv ]";
    }
}
