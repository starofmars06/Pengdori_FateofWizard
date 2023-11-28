using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using System.Collections;

public class PetRecognition : MonoBehaviour
{
    private bool prefabDetected = false;
    public AudioSource audioSource; // 효과음을 재생할 AudioSource 컴포넌트

    private void Awake()
    {
        // AudioSource 컴포넌트를 가져오기
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // AudioSource가 없으면 추가
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void Update()
    {
        if (CheckPrefabExistence() && !prefabDetected)
        {
            // 프리팹이 화면에 나타나면 기다린 후 다른 씬으로 전환
            StartCoroutine(WaitAndSwitchScene());
            prefabDetected = true; // 중복 호출 방지
        }
    }

    bool CheckPrefabExistence()
    {
        // 해당 프리팹의 인스턴스를 찾기
        GameObject[] instances = GameObject.FindGameObjectsWithTag("Pet");

        // 찾은 인스턴스가 존재하는지 여부 확인
        return instances.Length > 0;
    }

    IEnumerator WaitAndSwitchScene()
    {
        // 효과음 재생
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // 2초 대기
        yield return new WaitForSeconds(2f);

        // 다른 씬으로 전환
        SceneManager.LoadScene("04_1Intro");
    }
}
