using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PotionFailed : MonoBehaviour
{
    public Text result;
    public Text touch;

    IEnumerator Waittime()
    {
        yield return new WaitForSeconds(2f);

        result.text = "물약 만들기에 실패하였습니다.";

        touch.text = "터치하여 재도전";

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
        StartCoroutine(Waittime());
    }
}
