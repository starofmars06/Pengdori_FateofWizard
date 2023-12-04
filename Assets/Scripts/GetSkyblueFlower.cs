using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetSkyblueFlower : MonoBehaviour
{
    private float shakeThreshold1 = 6.5f; // 흔들림을 감지하기 위한 세기 임계값
    private float shakeThreshold2 = 2.5f; // 흔들림을 감지하기 위한 세기 임계값
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

        if (!PlayerPrefs.HasKey("PlantSkyblueNum")) // (이 디바이스에 PlantSkyblueNum을 한번이라도 저장한 적이 있는가)의 반대
        {
            PlayerPrefs.SetInt("PlantSkyblueNum", 0); // 이 디바이스에 PlantSkyblueNum을 저장한 적이 없다면 0 저장
        }
        if (!PlayerPrefs.HasKey("PlantSkyblueRandom"))
        {
            PlayerPrefs.SetInt("PlantSkyblueRandom", 0);
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
            PlayerPrefs.SetInt("PlantSkyblueRandom", plantRandomGet); // plantRandomGet의 값을 PlantSkyblueRandom에 저장함

            plantNum = PlayerPrefs.GetInt("PlantSkyblueNum"); // PlantSkyblueNum에 저장된 값 plantNum에 넣음
            PlayerPrefs.SetInt("PlantSkyblueNum", plantNum + plantRandomGet); // plantNum + plantRandomGet 한 결과를 PlantSkyblueNum에 저장함

            SceneManager.LoadScene("Plant_temp_result");
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