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
        // ��⿡ ����Ǿ��ִ� ���� �� �� ��������
        OrangeFlower = PlayerPrefs.GetInt("PlantOrangeNum");
        SkyblueFlower = PlayerPrefs.GetInt("PlantSkyblueNum");
        PinkFlower = PlayerPrefs.GetInt("PlantPinkNum");
        // ��⿡ ����Ǿ��ִ� ���� �� �� ��������
        MagicPotion1 = PlayerPrefs.GetInt("Potion1");
        MagicPotion2 = PlayerPrefs.GetInt("Potion2");
        MagicPotion3 = PlayerPrefs.GetInt("Potion3");

        // �� ���� �� ������Ʈ
        if (itemNum == 1)
        {
            ItemText.text = OrangeFlower + "��";
        }
        else if (itemNum == 2)
        {
            ItemText.text = SkyblueFlower + "��";
        }
        else if (itemNum == 3)
        {
            ItemText.text = PinkFlower + "��";
        }
        else if (itemNum == 4)
        {
            ItemText.text = MagicPotion1 + "��";
        }
        else if (itemNum == 5)
        {
            ItemText.text = MagicPotion2 + "��";
        }
        else if (itemNum == 6)
        {
            ItemText.text = MagicPotion3 + "��";
        }
    }
}
