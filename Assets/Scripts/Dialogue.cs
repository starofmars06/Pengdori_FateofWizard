using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;

    [TextArea(3, 10)]
    public string[] lines;
    public float textSpeed;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("SaveData", 0);

        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {

        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            //gameObject.SetActive(false);

            if (SceneManager.GetActiveScene().name == "03_1Intro")
            {
                //SaveData라는 값을 저장해서 다음번에는 03_2Intro로 넘어가게 된다.
                PlayerPrefs.SetInt("SaveData", 1);


                SceneManager.LoadScene("05Lobby");
            }
            else if (SceneManager.GetActiveScene().name == "03_2Intro")
            {
                SceneManager.LoadScene("05Lobby");
            }
            else if (SceneManager.GetActiveScene().name == "08_3AfterBattle")
            {
                SceneManager.LoadScene("05Lobby");
            }
                
        }
    }
}
