using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPetOnScreen : MonoBehaviour
{
    public GameObject prefabToCheck; // 판단하려는 프리팹

    void Update()
    {
        // 화면에 프리팹이 존재하는지 여부 확인
        bool prefabExists = CheckPrefabExistence();

        if (prefabExists)
        {
            Debug.Log("프리팹이 화면에 존재합니다.");
            // 2초 동안 대기 후 다른 씬으로 전환
            StartCoroutine(WaitAndSwitchScene());
        }
    }

    bool CheckPrefabExistence()
    {
        // 해당 프리팹이 화면에 있는지 여부 확인
        return GameObject.Find(prefabToCheck.name) != null;
    }

    IEnumerator WaitAndSwitchScene()
    {
        // 2초 대기
        yield return new WaitForSeconds(2f);

        // "Lobby" 씬으로 전환
        SceneManager.LoadScene("Lobby");
    }
}

