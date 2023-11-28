using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using System.Collections;

public class PetRecognition : MonoBehaviour
{
    private bool prefabDetected = false;
    public AudioSource audioSource; // ȿ������ ����� AudioSource ������Ʈ

    private void Awake()
    {
        // AudioSource ������Ʈ�� ��������
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // AudioSource�� ������ �߰�
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void Update()
    {
        if (CheckPrefabExistence() && !prefabDetected)
        {
            // �������� ȭ�鿡 ��Ÿ���� ��ٸ� �� �ٸ� ������ ��ȯ
            StartCoroutine(WaitAndSwitchScene());
            prefabDetected = true; // �ߺ� ȣ�� ����
        }
    }

    bool CheckPrefabExistence()
    {
        // �ش� �������� �ν��Ͻ��� ã��
        GameObject[] instances = GameObject.FindGameObjectsWithTag("Pet");

        // ã�� �ν��Ͻ��� �����ϴ��� ���� Ȯ��
        return instances.Length > 0;
    }

    IEnumerator WaitAndSwitchScene()
    {
        // ȿ���� ���
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // 2�� ���
        yield return new WaitForSeconds(2f);

        // �ٸ� ������ ��ȯ
        SceneManager.LoadScene("04_1Intro");
    }
}
