using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPetOnScreen : MonoBehaviour
{
    public GameObject prefabToCheck; // �Ǵ��Ϸ��� ������

    void Update()
    {
        // ȭ�鿡 �������� �����ϴ��� ���� Ȯ��
        bool prefabExists = CheckPrefabExistence();

        if (prefabExists)
        {
            Debug.Log("�������� ȭ�鿡 �����մϴ�.");
            // 2�� ���� ��� �� �ٸ� ������ ��ȯ
            StartCoroutine(WaitAndSwitchScene());
        }
    }

    bool CheckPrefabExistence()
    {
        // �ش� �������� ȭ�鿡 �ִ��� ���� Ȯ��
        return GameObject.Find(prefabToCheck.name) != null;
    }

    IEnumerator WaitAndSwitchScene()
    {
        // 2�� ���
        yield return new WaitForSeconds(2f);

        // "Lobby" ������ ��ȯ
        SceneManager.LoadScene("Lobby");
    }
}

