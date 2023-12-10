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
        yield return new WaitForSeconds(3f);
        
        touch.text = "��ġ�ؼ� �ڷ� ����";

        if (Input.touchCount > 0)
        {
            SceneManager.LoadScene("07_0PotionScene");
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
            result.text = "���� ��¦ �������� �ϼ��Ǿ����ϴ�.";
            touch.text = "����ġ 10 �߰�";
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("07_2YellowPotionCreateScene"))
        {
            result.text = "Ǫ�� ���� �������� �ϼ��Ǿ����ϴ�.";
            touch.text = "����ġ 10 �߰�";
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("07_3PurplePotionCreateScene"))
        {
            result.text = "���� �Ҳ� �������� �ϼ��Ǿ����ϴ�.";
            touch.text = "����ġ 10 �߰�";
        }
        
        StartCoroutine(Waittime());
    }
}
