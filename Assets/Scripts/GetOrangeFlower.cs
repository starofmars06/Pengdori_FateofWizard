using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetOrangeFlower : MonoBehaviour
{
    private float shakeThreshold1 = 6.5f; // ��鸲�� �����ϱ� ���� ���� �Ӱ谪
    private float shakeThreshold2 = 2.5f; // ��鸲�� �����ϱ� ���� ���� �Ӱ谪
    private Vector3 acceleration;
    private Vector3 currentAcceleration;
    private Vector3 deltaAcceleration;
    private int plantNum;
    private int plantRandomGet;
    GameObject[] effectObj;


    void Awake()
    {
        effectObj = GameObject.FindGameObjectsWithTag("get");
        foreach (GameObject obj in effectObj)
        {
            obj.SetActive(false);
        }

        if (!PlayerPrefs.HasKey("PlantOrangeNum")) // (�� ����̽��� PlantOrangeNum�� �ѹ��̶� ������ ���� �ִ°�)�� �ݴ�
        {
            PlayerPrefs.SetInt("PlantOrangeNum", 0); // �� ����̽��� PlantOrangeNum�� ������ ���� ���ٸ� 0 ����
        }
        if (!PlayerPrefs.HasKey("PlantOrangeRandom"))
        {
            PlayerPrefs.SetInt("PlantOrangeRandom", 0);
        }
    }

    void Start()
    {
        acceleration = Input.acceleration;
        currentAcceleration = Input.acceleration;
    }

    void Update()
    {
        // ���ӵ� ������ ����
        currentAcceleration = Input.acceleration;

        // ���ӵ� ��ȭ ���
        deltaAcceleration = currentAcceleration - acceleration;

        if (deltaAcceleration.sqrMagnitude >= shakeThreshold1 * shakeThreshold1) // 6.5 ���� �̻����� ��鸰 ���
        {
            // ��鸲�� ���� �߰� �۾�
            plantRandomGet = Random.Range(1, 6); // 1~5������ �� ����
            PlayerPrefs.SetInt("PlantOrangeRandom", plantRandomGet); // plantRandomGet�� ���� PlantOrangeRandom�� ������

            plantNum = PlayerPrefs.GetInt("PlantOrangeNum"); // PlantOrangeNum�� ����� �� plantNum�� ����
            PlayerPrefs.SetInt("PlantOrangeNum", plantNum + plantRandomGet); // plantNum + plantRandomGet �� ����� PlantOrangeNum�� ������

            SceneManager.LoadScene("06_9Plant_result");
        }
        else if (deltaAcceleration.sqrMagnitude >= shakeThreshold2 * shakeThreshold2) // 2.5 ���� �̻����� ��鸰 ���
        {
            // ��鸲�� ���� �߰� �۾�
            foreach (GameObject obj in effectObj)
            {
                obj.SetActive(true);
            }
        }

        // ���ӵ� ������ ������Ʈ
        acceleration = currentAcceleration;
    }
}
