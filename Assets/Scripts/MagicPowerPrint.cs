using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicPowerPrint : MonoBehaviour
{
    public Text magicPowerText;

    int current_magicPower;
    int update_magicPower;

    void Start()
    {
        UpdateMagicPowerGetUI();
    }

    void UpdateMagicPowerGetUI()
    {
        current_magicPower = PlayerPrefs.GetInt("MagicPower");
        update_magicPower = 500 + current_magicPower;

        PlayerPrefs.SetInt("MagicPower", update_magicPower);

        magicPowerText.text = "[ รั Magic Power: " + update_magicPower + " ]";
    }
}
