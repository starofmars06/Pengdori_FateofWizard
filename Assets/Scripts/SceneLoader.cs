using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 2f;

    void Update()
    {
        // 01. 인트로 시퀀스에 대한 화면 전환
        if (SceneManager.GetActiveScene().name == "01Logo") //&& Input.GetMouseButtonDown(0))
        {
            LoadTitleScene();
        }

        
        if (SceneManager.GetActiveScene().name == "02Title" && Input.GetMouseButtonDown(0))
        {
            LoadMainScene();
        }

        //8. 일반 몬스터 물리친 후 이동
        if (SceneManager.GetActiveScene().name == "08_2Fight_Win" && Input.GetMouseButtonDown(0))
        {
            LoadAfterBattleScene();
        }

        // 11. 최종보스 물리친 후 이동
        if (SceneManager.GetActiveScene().name == "11_3Win" && Input.GetMouseButtonDown(0))
        {
            LoadFinalScene();
        }

        // 게임 엔딩
        if (SceneManager.GetActiveScene().name == "12_1EndingCredits" && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("01Logo");
        }

    }

    public void LoadTitleScene()
    {
        StartCoroutine(LoadTitle());
    }

    IEnumerator LoadTitle()
    {
        //기다리기
        yield return new WaitForSeconds(2);

        //애니메이션 시작
        transition.SetTrigger("Start");

        //기다리기
        yield return new WaitForSeconds(transitionTime);

        //씬 적용하기
        SceneManager.LoadScene("02Title");
    }

    
    public void LoadMainScene()
    {
        StartCoroutine(LoadMain());
    }

    IEnumerator LoadMain()
    {
        //애니메이션 시작
        transition.SetTrigger("Start");

        //기다리기
        yield return new WaitForSeconds(transitionTime);

        //씬 적용하기
        SceneManager.LoadScene("03Intro");
    }

    //일반 전투 후 이동
    public void LoadAfterBattleScene()
    {
        StartCoroutine(LoadAfterBattle());
    }

    IEnumerator LoadAfterBattle()
    {
        //애니메이션 시작
        transition.SetTrigger("Start");

        //기다리기
        yield return new WaitForSeconds(transitionTime);

        //씬 적용하기
        SceneManager.LoadScene("08_3AfterBattle");
    }


    //최종 보스 전투 후 이동
    public void LoadFinalScene()
    {
        StartCoroutine(LoadFinal());
    }

    IEnumerator LoadFinal()
    {
        //애니메이션 시작
        transition.SetTrigger("Start");

        //기다리기
        yield return new WaitForSeconds(transitionTime);

        //씬 적용하기
        SceneManager.LoadScene("11_4Ending");
    }

}


