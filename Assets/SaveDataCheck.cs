using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void awake()
    {
        if (!PlayerPrefs.HasKey("SaveData")) // (이 디바이스에 SaveData을 한번이라도 저장한 적이 있는가)의 반대
        {
            PlayerPrefs.SetInt("SaveData", 0); // 이 디바이스에 SaveData을 저장한 적이 없다면 0 저장
        }
    }
}
