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
        result.text = "���� a�� �ϼ��Ǿ����ϴ�.";
        StartCoroutine(Waittime());
    }
}
