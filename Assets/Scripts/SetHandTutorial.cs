using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHandTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("HandTutorial", 0);

        //초기 테스팅을 위한 값.
        //PlayerPrefs.SetInt("Potion1", 1);
        //PlayerPrefs.SetInt("Potion2", 1);
        //PlayerPrefs.SetInt("Potion3", 1);
    }
}
