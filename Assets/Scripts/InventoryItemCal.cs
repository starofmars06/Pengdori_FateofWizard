using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemCal : MonoBehaviour
{
    [SerializeField]
    public int itemNum;

    public Text ItemText;

    private int OrangeFlower, SkyblueFlower, PinkFlower, MagicPotion1, MagicPotion2, MagicPotion3;

    void Awake()
    {
        ItemText = GetComponent<Text>();
    }

    void LateUpdate()
    {
        // 기기에 저장되어있는 약초 총 수 가져오기
        OrangeFlower = PlayerPrefs.GetInt("PlantOrangeNum");
        SkyblueFlower = PlayerPrefs.GetInt("PlantSkyblueNum");
        PinkFlower = PlayerPrefs.GetInt("PlantPinkNum");
        // 기기에 저장되어있는 포션 총 수 가져오기
        MagicPotion1 = PlayerPrefs.GetInt("Potion1");
        MagicPotion2 = PlayerPrefs.GetInt("Potion2");
        MagicPotion3 = PlayerPrefs.GetInt("Potion3");

        // 각 약초 수 업데이트
        if (itemNum == 1)
        {
            ItemText.text = OrangeFlower + "개";
        }
        else if (itemNum == 2)
        {
            ItemText.text = SkyblueFlower + "개";
        }
        else if (itemNum == 3)
        {
            ItemText.text = PinkFlower + "개";
        }
        else if (itemNum == 4)
        {
            ItemText.text = MagicPotion1 + "개";
        }
        else if (itemNum == 5)
        {
            ItemText.text = MagicPotion2 + "개";
        }
        else if (itemNum == 6)
        {
            ItemText.text = MagicPotion3 + "개";
        }
    }
}
