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

        result.text = "���� ����⿡ �����Ͽ����ϴ�.";

        touch.text = "��ġ�Ͽ� �絵��";

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
