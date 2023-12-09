using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPotion : MonoBehaviour
{
    public Text potion1;
    public Text potion2;
    public Text potion3;

    //���� ���� ����;
    int MagicPotion1;
    int MagicPotion2;
    int MagicPotion3;

    // Start is called before the first frame update
    void Start()
    {
        // �� ó���� ��⿡ ����Ǿ��ִ� ���� �� �� ��������
        MagicPotion1 = PlayerPrefs.GetInt("Potion1");
        MagicPotion2 = PlayerPrefs.GetInt("Potion2");
        MagicPotion3 = PlayerPrefs.GetInt("Potion3");

        InitalPotionUI();   //�� �����Ӹ��� ����� ���� Ȯ���ϰ� ������Ʈ
    }

    void InitalPotionUI()
    {
        potion1.text = "����: " + MagicPotion1.ToString();
        potion2.text = "����: " + MagicPotion2.ToString();
        potion3.text = "����: " + MagicPotion3.ToString();

    }

}
