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
        result.text = "물약 a가 완성되었습니다.";
        StartCoroutine(Waittime());
    }
}
