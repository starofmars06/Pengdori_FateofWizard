using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPotion : MonoBehaviour
{
    public Text potion1;
    public Text potion2;
    public Text potion3;

    //마법 물약 개수;
    int MagicPotion1;
    int MagicPotion2;
    int MagicPotion3;

    // Start is called before the first frame update
    void Start()
    {
        // 맨 처음에 기기에 저장되어있는 포션 총 수 가져오기
        MagicPotion1 = PlayerPrefs.GetInt("Potion1");
        MagicPotion2 = PlayerPrefs.GetInt("Potion2");
        MagicPotion3 = PlayerPrefs.GetInt("Potion3");

        InitalPotionUI();   //매 프레임마다 사용한 포션 확인하고 업데이트
    }

    void InitalPotionUI()
    {
        potion1.text = "별빛: " + MagicPotion1.ToString();
        potion2.text = "전기: " + MagicPotion2.ToString();
        potion3.text = "포털: " + MagicPotion3.ToString();

    }

}
