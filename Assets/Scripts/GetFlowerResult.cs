using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetFlowerResult : MonoBehaviour
{
    public Text myText;
    public int plant0rangeRandom;
    public int plantOrangeSum;
    public int plantSkyblueRandom;
    public int plantSkyblueSum;
    public int plantPinkRandom;
    public int plantPinkSum;
    private int magicPower_Get;
    private int magicPower_Sum;

    void Awake()
    {
        myText = GetComponent<Text>();
    }

    void LateUpdate() // Update���� ����� ���� ������ ���� �Ϸ��� �� ��
    {
        plant0rangeRandom = PlayerPrefs.GetInt("PlantOrangeRandom");
        plantOrangeSum = PlayerPrefs.GetInt("PlantOrangeNum");
        plantSkyblueRandom = PlayerPrefs.GetInt("PlantSkyblueRandom");
        plantSkyblueSum = PlayerPrefs.GetInt("PlantSkyblueNum");
        plantPinkRandom = PlayerPrefs.GetInt("PlantPinkRandom");
        plantPinkSum = PlayerPrefs.GetInt("PlantPinkNum");
        magicPower_Get = PlayerPrefs.GetInt("MagicPowerGet");
        magicPower_Sum = PlayerPrefs.GetInt("MagicPower");

        myText.text = "���� ���׻� ���� ��: " + plant0rangeRandom + " / �� ��Ȳ�� ���� ��: " + plantOrangeSum 
            + "\n���� �ϴû� ���� ��: " + plantSkyblueRandom + " / �� �ϴû� ���� ��: " + plantSkyblueSum 
            + "\n���� ��ȫ�� ���� ��: " + plantPinkRandom + " / �� ��ȫ�� ���� ��: " + plantPinkSum
            + "\n���� Magic Power: " + magicPower_Get + " / �� Magic Power: " + magicPower_Sum;
    }
}
