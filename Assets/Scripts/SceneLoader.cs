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
        // 01. ��Ʈ�� �������� ���� ȭ�� ��ȯ
        if (SceneManager.GetActiveScene().name == "01Logo") //&& Input.GetMouseButtonDown(0))
        {
            LoadTitleScene();
        }

        
        if (SceneManager.GetActiveScene().name == "02Title" && Input.GetMouseButtonDown(0))
        {
            LoadMainScene();
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
        StartCoroutine(LoadMain());
    }

    IEnumerator LoadMain()
    {
        //�ִϸ��̼� ����
        transition.SetTrigger("Start");

        //��ٸ���
        yield return new WaitForSeconds(transitionTime);

        //�� �����ϱ�
        SceneManager.LoadScene("03Main");
    }
    
}

