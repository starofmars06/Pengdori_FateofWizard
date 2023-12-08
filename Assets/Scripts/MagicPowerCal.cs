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
        if (!PlayerPrefs.HasKey("PlantOrangeNum")) // (�� ����̽��� PlantOrangeNum�� �ѹ��̶� ������ ���� �ִ°�)�� �ݴ�
        {
            PlayerPrefs.SetInt("PlantOrangeNum", 0); // �� ����̽��� PlantOrangeNum�� ������ ���� ���ٸ� 0 ����
        }
        if (!PlayerPrefs.HasKey("PlantOrangeRandom"))
        {
            PlayerPrefs.SetInt("PlantOrangeRandom", 0);
        }

        if (!PlayerPrefs.HasKey("PlantSkyblueNum")) // (�� ����̽��� PlantSkyblueNum�� �ѹ��̶� ������ ���� �ִ°�)�� �ݴ�
        {
            PlayerPrefs.SetInt("PlantSkyblueNum", 0); // �� ����̽��� PlantSkyblueNum�� ������ ���� ���ٸ� 0 ����
        }
        if (!PlayerPrefs.HasKey("PlantSkyblueRandom"))
        {
            PlayerPrefs.SetInt("PlantSkyblueRandom", 0);
        }

        if (!PlayerPrefs.HasKey("PlantPinkNum")) // (�� ����̽��� PlantPinkNum�� �ѹ��̶� ������ ���� �ִ°�)�� �ݴ�
        {
            PlayerPrefs.SetInt("PlantPinkNum", 0); // �� ����̽��� PlantPinkNum�� ������ ���� ���ٸ� 0 ����
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

        level = magicPowerSum / 100;
        level = level + 1;

        magicPowerText.text = "Magic Power : " + magicPowerSum + "[ " + level + " Lv ]";
    }
}
