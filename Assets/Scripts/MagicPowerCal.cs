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
        if (!PlayerPrefs.HasKey("MagicPower")) // (�� ����̽��� MagicPower�� �ѹ��̶� ������ ���� �ִ°�)�� �ݴ�
        {
            PlayerPrefs.SetInt("MagicPower", 0); // �� ����̽��� MagicPower�� ������ ���� ���ٸ� 0 ����
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
