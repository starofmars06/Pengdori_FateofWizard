using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;


public class FlowerController : MonoBehaviour
{
    private bool prefabDetected = false;
    //public float speed = 15;

    private void Awake()
    {
        
    }

    void Start()
    {
        
    }


    private void Update()
    {
        if (CheckPrefabExistence1() && !prefabDetected)
        {
            // 프리팹이 화면에 나타나면 기다린 후 다른 씬으로 전환
            StartCoroutine(WaitAndSwitchScene1());
            prefabDetected = true; // 중복 호출 방지
        }

        if (CheckPrefabExistence2() && !prefabDetected)
        {
            // 프리팹이 화면에 나타나면 기다린 후 다른 씬으로 전환
            StartCoroutine(WaitAndSwitchScene2());
            prefabDetected = true; // 중복 호출 방지
        }

        if (CheckPrefabExistence3() && !prefabDetected)
        {
            // 프리팹이 화면에 나타나면 기다린 후 다른 씬으로 전환
            StartCoroutine(WaitAndSwitchScene3());
            prefabDetected = true; // 중복 호출 방지
        }

    }

    bool CheckPrefabExistence1()
    {
        // 해당 프리팹의 인스턴스를 찾기
        GameObject[] instances1 = GameObject.FindGameObjectsWithTag("flower1");

        // 찾은 인스턴스가 존재하는지 여부 확인
        return instances1.Length > 0;
    }

    bool CheckPrefabExistence2()
    {
        // 해당 프리팹의 인스턴스를 찾기
        GameObject[] instances2 = GameObject.FindGameObjectsWithTag("flower2");

        // 찾은 인스턴스가 존재하는지 여부 확인
        return instances2.Length > 0;
    }

    bool CheckPrefabExistence3()
    {
        // 해당 프리팹의 인스턴스를 찾기
        GameObject[] instances3 = GameObject.FindGameObjectsWithTag("flower3");

        // 찾은 인스턴스가 존재하는지 여부 확인
        return instances3.Length > 0;
    }

    IEnumerator WaitAndSwitchScene1()
    {

        // 3초 대기
        yield return new WaitForSeconds(3f);

        // 다른 씬으로 전환
        SceneManager.LoadScene("06_1Plant");
    }

    IEnumerator WaitAndSwitchScene2()
    {

        // 3초 대기
        yield return new WaitForSeconds(3f);

        // 다른 씬으로 전환
        SceneManager.LoadScene("06_2Plant");
    }

    IEnumerator WaitAndSwitchScene3()
    {

        // 3초 대기
        yield return new WaitForSeconds(3f);

        // 다른 씬으로 전환
        SceneManager.LoadScene("06_3Plant");
    }

}