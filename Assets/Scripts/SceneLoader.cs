using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 2f;

    int hasSaveData;

    void Start()
    {
        hasSaveData = PlayerPrefs.GetInt("SaveData");
    }

    void Update()
    {
        // 01. ��Ʈ�� �������� ���� ȭ�� ��ȯ
        if (SceneManager.GetActiveScene().name == "01Logo") //&& Input.GetMouseButtonDown(0))
        {
            LoadTitleScene();
        }

        
        if (SceneManager.GetActiveScene().name == "02Title" && Input.GetMouseButtonDown(0))
        {
            LoadMainScene();
        }

        //8. �Ϲ� ���� ����ģ �� �̵�
        if (SceneManager.GetActiveScene().name == "08_2Fight_Win" && Input.GetMouseButtonDown(0))
        {
            LoadAfterBattleScene();
        }

        // 11. �������� ����ģ �� �̵�
        if (SceneManager.GetActiveScene().name == "11_3Win" && Input.GetMouseButtonDown(0))
        {
            LoadFinalScene();
        }

        // ���� ����
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
        //��ٸ���
        yield return new WaitForSeconds(2);

        //�ִϸ��̼� ����
        transition.SetTrigger("Start");

        //��ٸ���
        yield return new WaitForSeconds(transitionTime);

        //�� �����ϱ�
        SceneManager.LoadScene("02Title");
    }

    
    public void LoadMainScene()
    {
        if (hasSaveData == 1)
        {
            //�ִٸ� ���� ȯ�� ��������
            StartCoroutine(LoadMain1());
        }
        else
        {
            //���̺� �����Ͱ� ������ ù ��Ʈ�κ���
            StartCoroutine(LoadMain2());
        }
    }

    IEnumerator LoadMain2()
    {
        //�ִϸ��̼� ����
        transition.SetTrigger("Start");

        //��ٸ���
        yield return new WaitForSeconds(transitionTime);

        //�� �����ϱ�
        SceneManager.LoadScene("03_1Intro");
    }

    IEnumerator LoadMain1()
    {
        //�ִϸ��̼� ����
        transition.SetTrigger("Start");

        //��ٸ���
        yield return new WaitForSeconds(transitionTime);

        //�� �����ϱ�
        SceneManager.LoadScene("03_2Intro");
    }

    //�Ϲ� ���� �� �̵�
    public void LoadAfterBattleScene()
    {
        StartCoroutine(LoadAfterBattle());
    }

    IEnumerator LoadAfterBattle()
    {
        //�ִϸ��̼� ����
        transition.SetTrigger("Start");

        //��ٸ���
        yield return new WaitForSeconds(transitionTime);

        //�� �����ϱ�
        SceneManager.LoadScene("08_3AfterBattle");
    }


    //���� ���� ���� �� �̵�
    public void LoadFinalScene()
    {
        StartCoroutine(LoadFinal());
    }

    IEnumerator LoadFinal()
    {
        //�ִϸ��̼� ����
        transition.SetTrigger("Start");

        //��ٸ���
        yield return new WaitForSeconds(transitionTime);

        //�� �����ϱ�
        SceneManager.LoadScene("11_4Ending");
    }

}


