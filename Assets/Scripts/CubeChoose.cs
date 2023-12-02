using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CubeChoose : MonoBehaviour
{

    //카메라로부터의 position 설정으로 수정 필요
    //button touch 문제 해결

    public GameObject Redflower;
    public GameObject Blueflower;
    public GameObject Yellowflower;
    public GameObject Cauldron;

    public int RCount;
    public int YCount;
    public int BCount;
    public int count = 0;

    public Button leftButton;
    public Button rightButton;
    public Button mixButton;

    public List<string> mix;

    public Text res;

    // Start is called before the first frame update
    void Start()
    {
        mixButton = GetComponent<Button>();

        leftButton = GetComponent<Button>();
        rightButton = GetComponent<Button>();

        mix.Clear();
        
        Redflower.transform.position = new Vector3(0, -1, 3);
        Yellowflower.transform.position = new Vector3(1, -0.5f, 4);
        Blueflower.transform.position = new Vector3(-1, -0.5f, 4);

        Redflower.SetActive(true);
        Blueflower.SetActive(true);
        Yellowflower.SetActive(true);
        Cauldron.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    Debug.Log("터치된 오브젝트: " + hit.collider.gameObject.name);
                    if (hit.collider.gameObject.tag == "Cube")
                    {
                        mix.Add(hit.collider.gameObject.name);
                        count++;
                        res.text = hit.collider.gameObject.name;

                        if (count >= 3)
                        {
                            
                        }
                    }
                }
            }
        }

    }

    public void OnButtonClick()
    {
        res.text = "mix";

        for (int i = 0; i < mix.Count; i++)
        {
            switch (mix[i])
            {
                case "RedFlower":
                    RCount++;
                    break;
                case "YellowFlower":
                    YCount++;
                    break;
                case "BlueFlower":
                    BCount++;
                    break;
            }
        }

        List<int> mixCount = new List<int> { RCount, YCount, BCount };

        if (mixCount.SequenceEqual(new List<int> { 2, 1, 0 }))
        {
            res.text = "성공";
        }
        else if (mixCount.SequenceEqual(new List<int> { 1, 1, 0 }))
        {
            res.text = "성공";
        }
        else if (mixCount.SequenceEqual(new List<int> { 0, 0, 2 }))
        {
            res.text = "성공";
        }
        else if (mixCount.SequenceEqual(new List<int> { 1, 1, 1 }))
        {
            res.text = "성공";
        }
        else if (mixCount.SequenceEqual(new List<int> { 0, 1, 1 }))
        {
            res.text = "성공";
        }
        else if (mixCount.SequenceEqual(new List<int> { 0, 3, 0 }))
        {
            res.text = "성공";
        }
        else if (mixCount.SequenceEqual(new List<int> { 1, 0, 2 }))
        {
            res.text = "성공";
        }
        else
        {
            res.text = "실패";
        }
        mix.Clear();
        mixCount.Clear();
        RCount = 0;
        YCount = 0;
        BCount = 0;

    }

    public void OnRotateButtonClick(string button)
    {
        if (button == "left")
        {
            Vector3 tempvector = Redflower.transform.position;
            Redflower.transform.position = Yellowflower.transform.position;
            Yellowflower.transform.position = Blueflower.transform.position;
            Blueflower.transform.position = tempvector;
            res.text = "왼쪽";
        }

        if (button == "right")
        {
            Vector3 tempvector = Redflower.transform.position;
            Redflower.transform.position = Blueflower.transform.position;
            Blueflower.transform.position = Yellowflower.transform.position;
            Yellowflower.transform.position = tempvector;
            res.text = "오른쪽";
        }
    }

}
