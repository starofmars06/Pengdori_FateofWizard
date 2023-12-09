using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PotionMove : MonoBehaviour
{
    public Text result;
    public Text touch;

    IEnumerator Waittime()
    {
        yield return new WaitForSeconds(2f);
        
        touch.text = "터치해서 뒤로 가기";

        if (Input.touchCount > 0)
        {
            SceneManager.LoadScene("PotionScene");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("07_1RedPotionCreateScene"))
        {
            result.text = "별빛 반짝 마법약이 완성되었습니다.";
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("07_2YellowPotionCreateScene"))
        {
            result.text = "푸른 전기 마법약이 완성되었습니다.";
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("07_3PurplePotionCreateScene"))
        {
            result.text = "포털 불꽃 마법약이 완성되었습니다.";
        }
        
        StartCoroutine(Waittime());
    }
}
