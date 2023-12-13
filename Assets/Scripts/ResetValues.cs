using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetValues : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //새 게임을 위해서 저장되었던 값 모두 초기화하기
        PlayerPrefs.SetInt("PlantOrangeNum", 0);
        PlayerPrefs.SetInt("PlantSkyblueNum", 0);
        PlayerPrefs.SetInt("PlantPinkNum", 0);

        PlayerPrefs.SetInt("MagicPower", 0);

        PlayerPrefs.SetInt("Potion1", 0);
        PlayerPrefs.SetInt("Potion2", 0);
        PlayerPrefs.SetInt("Potion3", 0);

        PlayerPrefs.SetInt("SaveData", 0);
    }
}
