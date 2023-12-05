using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicPowerCal : MonoBehaviour
{
    public Text magicPowerText;
    public int magicPowerSum;

    void Awake()
    {
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

        magicPowerText.text = "Magic Power : " + magicPowerSum;
    }
}
