using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlowerMove : MonoBehaviour
{
    public GameObject Redflower;
    public GameObject Blueflower;
    public GameObject Yellowflower;
    public GameObject Cauldron;

    public int rotatei = 0;
    public int num;

    public int count;

    public string name;

    public Text FlowerNum;
    public Text res;

    Rigidbody rb;
    bool isReady = true;
    
    Vector2 startPos;
    Vector2 endPos;
    Vector2 touchDistance;

    private float swipeSensitivity = 0.5f;

    public float resetTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

        Redflower.SetActive(true);
        Yellowflower.SetActive(false);
        Blueflower.SetActive(false);

        rb = Redflower.GetComponent<Rigidbody>();
        rb.isKinematic = true;

        SetPosition(FlowerMain(), Camera.main.transform);

    }

    // Update is called once per frame
    void Update()
    {
        if (!isReady)
        {
            return;
        }

        SetPosition(FlowerMain(), Camera.main.transform);

        if (Input.touchCount > 0 && isReady)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startPos = touch.position;
                
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endPos = touch.position;
                touchDistance = endPos - startPos;

                if(Mathf.Abs(touchDistance.y) > swipeSensitivity || Mathf.Abs(touchDistance.x) > swipeSensitivity)
                {
                    if (touchDistance.y > 0 && Mathf.Abs(touchDistance.y) > Mathf.Abs(touchDistance.x))
                    {
                        if (num <= 0)
                        {
                            
                        }
                        else
                        {
                            FlowerThrow();
                        }
                    }
                    else if (touchDistance.x > 0 && Mathf.Abs(touchDistance.x) > Mathf.Abs(touchDistance.y))
                    {
                        FlowerRotate(1);
                        SetPosition(FlowerMain(), Camera.main.transform);
                    }
                    else if (touchDistance.x < 0 && Mathf.Abs(touchDistance.x) > Mathf.Abs(touchDistance.y))
                    {
                        FlowerRotate(-1);
                        SetPosition(FlowerMain(), Camera.main.transform);
                    }
                }

            }
        }
    }

    void FlowerThrow()
    {
        Vector3 throwAngle = (Camera.main.transform.forward + Camera.main.transform.up).normalized;

        rb.isKinematic = false;
        isReady = false;

        rb.AddForce(throwAngle * touchDistance.magnitude * 0.005f, ForceMode.VelocityChange);

        Invoke("Reset", resetTime);
    }


    void SetPosition(GameObject flower, Transform anchor)
    {
        Vector3 offset = anchor.forward * 0.5f + anchor.up * -0.2f;
        flower.transform.position = anchor.position + offset;
        rb = flower.GetComponent<Rigidbody>();
        rb.isKinematic = true;
        if (flower == Redflower)
        {
            name = "PlantPinkNum";
            num = PlayerPrefs.GetInt("PlantPinkNum");
        }
        else if (flower == Blueflower)
        {
            name = "PlantOrangeNum";
            num = PlayerPrefs.GetInt("PlantOrangeNum");
        }
        else if (flower == Yellowflower)
        {
            name = "PlantSkyblueNum";
            num = PlayerPrefs.GetInt("PlantSkyblueNum");
        }
        res.text = num.ToString();
    }

    void FlowerRotate(int i)
    {
        if(i == 1)
        {
            rotatei++;
            if (rotatei > 2)
            {
                rotatei = 0;
            }
        }
        else if (i == -1)
        {
            rotatei--;
            if (rotatei < 0)
            {
                rotatei = 2;
            }
        }
        
    }

    private GameObject FlowerMain()
    {

        if (rotatei == 0)
        {
            Redflower.SetActive(true);
            Yellowflower.SetActive(false);
            Blueflower.SetActive(false);

            return Redflower;
        }
        else if (rotatei == 1)
        {
            Redflower.SetActive(false);
            Yellowflower.SetActive(false);
            Blueflower.SetActive(true);

            return Blueflower;
        }
        else
        {
            Redflower.SetActive(false);
            Yellowflower.SetActive(true);
            Blueflower.SetActive(false);

            return Yellowflower;
        }
    }

    private void Reset()
    {
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;

        isReady = true;
    }

    public void Return()
    {
        SceneManager.LoadScene("05Lobby");
    }
}
