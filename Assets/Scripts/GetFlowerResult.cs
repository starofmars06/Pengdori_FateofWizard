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

    void LateUpdate() // Update에서 계산한 값을 가지고 뭔가 하려고 할 때
    {
        plant0rangeRandom = PlayerPrefs.GetInt("PlantOrangeRandom");
        plantOrangeSum = PlayerPrefs.GetInt("PlantOrangeNum");
        plantSkyblueRandom = PlayerPrefs.GetInt("PlantSkyblueRandom");
        plantSkyblueSum = PlayerPrefs.GetInt("PlantSkyblueNum");
        plantPinkRandom = PlayerPrefs.GetInt("PlantPinkRandom");
        plantPinkSum = PlayerPrefs.GetInt("PlantPinkNum");
        magicPower_Get = PlayerPrefs.GetInt("MagicPowerGet");
        magicPower_Sum = PlayerPrefs.GetInt("MagicPower");

        myText.text = "얻은 주항색 약초 수: " + plant0rangeRandom + " / 총 주황색 약초 수: " + plantOrangeSum 
            + "\n얻은 하늘색 약초 수: " + plantSkyblueRandom + " / 총 하늘색 약초 수: " + plantSkyblueSum 
            + "\n얻은 분홍색 약초 수: " + plantPinkRandom + " / 총 분홍색 약초 수: " + plantPinkSum
            + "\n얻은 Magic Power: " + magicPower_Get + " / 총 Magic Power: " + magicPower_Sum;
    }
}
