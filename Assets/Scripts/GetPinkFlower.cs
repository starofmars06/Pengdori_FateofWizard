using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetPinkFlower : MonoBehaviour
{
    private float shakeThreshold1 = 6.5f; // 흔들림을 감지하기 위한 세기 임계값
    private float shakeThreshold2 = 2.5f; // 흔들림을 감지하기 위한 세기 임계값
    private Vector3 acceleration;
    private Vector3 currentAcceleration;
    private Vector3 deltaAcceleration;
    private int plantNum;
    private int plantRandomGet;
    private int magicPowerNum;
    private int magicPowerGet;
    GameObject[] effectObj;


    void Awake()
    {
        effectObj = GameObject.FindGameObjectsWithTag("get");
        foreach (GameObject obj in effectObj)
        {
            obj.SetActive(false);
        }
    }

    void Start()
    {
        acceleration = Input.acceleration;
        currentAcceleration = Input.acceleration;
    }

    void Update()
    {
        // 가속도 데이터 갱신
        currentAcceleration = Input.acceleration;

        // 가속도 변화 계산
        deltaAcceleration = currentAcceleration - acceleration;

        if (deltaAcceleration.sqrMagnitude >= shakeThreshold1 * shakeThreshold1) // 6.5 세기 이상으로 흔들린 경우
        {
            // 흔들림에 대한 추가 작업
            plantRandomGet = Random.Range(1, 6); // 1~5사이의 수 랜덤
            PlayerPrefs.SetInt("PlantPinkRandom", plantRandomGet); // plantRandomGet의 값을 PlantPinkRandom에 저장함

            plantNum = PlayerPrefs.GetInt("PlantPinkNum"); // PlantPinkNum에 저장된 값 plantNum에 넣음
            PlayerPrefs.SetInt("PlantPinkNum", plantNum + plantRandomGet); // plantNum + plantRandomGet 한 결과를 PlantPinkNum에 저장함

            PlayerPrefs.SetInt("PlantOrangeRandom", 0);
            PlayerPrefs.SetInt("PlantSkyblueRandom", 0);

            magicPowerGet = 100; // MagicPower 얻는 부분
            PlayerPrefs.SetInt("MagicPowerGet", magicPowerGet);
            magicPowerNum = PlayerPrefs.GetInt("MagicPower");
            PlayerPrefs.SetInt("MagicPower", magicPowerNum + magicPowerGet);

            SceneManager.LoadScene("06_9Plant_result");
        }
        else if (deltaAcceleration.sqrMagnitude >= shakeThreshold2 * shakeThreshold2) // 2.5 세기 이상으로 흔들린 경우
        {
            // 흔들림에 대한 추가 작업
            foreach (GameObject obj in effectObj)
            {
                obj.SetActive(true);
            }
        }

        // 가속도 데이터 업데이트
        acceleration = currentAcceleration;
    }
}