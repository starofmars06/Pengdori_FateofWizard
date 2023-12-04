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
            // �������� ȭ�鿡 ��Ÿ���� ��ٸ� �� �ٸ� ������ ��ȯ
            StartCoroutine(WaitAndSwitchScene1());
            prefabDetected = true; // �ߺ� ȣ�� ����
        }

        if (CheckPrefabExistence2() && !prefabDetected)
        {
            // �������� ȭ�鿡 ��Ÿ���� ��ٸ� �� �ٸ� ������ ��ȯ
            StartCoroutine(WaitAndSwitchScene2());
            prefabDetected = true; // �ߺ� ȣ�� ����
        }

        if (CheckPrefabExistence3() && !prefabDetected)
        {
            // �������� ȭ�鿡 ��Ÿ���� ��ٸ� �� �ٸ� ������ ��ȯ
            StartCoroutine(WaitAndSwitchScene3());
            prefabDetected = true; // �ߺ� ȣ�� ����
        }

    }

    bool CheckPrefabExistence1()
    {
        // �ش� �������� �ν��Ͻ��� ã��
        GameObject[] instances1 = GameObject.FindGameObjectsWithTag("flower1");

        // ã�� �ν��Ͻ��� �����ϴ��� ���� Ȯ��
        return instances1.Length > 0;
    }

    bool CheckPrefabExistence2()
    {
        // �ش� �������� �ν��Ͻ��� ã��
        GameObject[] instances2 = GameObject.FindGameObjectsWithTag("flower2");

        // ã�� �ν��Ͻ��� �����ϴ��� ���� Ȯ��
        return instances2.Length > 0;
    }

    bool CheckPrefabExistence3()
    {
        // �ش� �������� �ν��Ͻ��� ã��
        GameObject[] instances3 = GameObject.FindGameObjectsWithTag("flower3");

        // ã�� �ν��Ͻ��� �����ϴ��� ���� Ȯ��
        return instances3.Length > 0;
    }

    IEnumerator WaitAndSwitchScene1()
    {

        // 3�� ���
        yield return new WaitForSeconds(3f);

        // �ٸ� ������ ��ȯ
        SceneManager.LoadScene("06_1Plant");
    }

    IEnumerator WaitAndSwitchScene2()
    {

        // 3�� ���
        yield return new WaitForSeconds(3f);

        // �ٸ� ������ ��ȯ
        SceneManager.LoadScene("06_2Plant");
    }

    IEnumerator WaitAndSwitchScene3()
    {

        // 3�� ���
        yield return new WaitForSeconds(3f);

        // �ٸ� ������ ��ȯ
        SceneManager.LoadScene("06_3Plant");
    }

}