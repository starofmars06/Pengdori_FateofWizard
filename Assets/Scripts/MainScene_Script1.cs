using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene_Script1 : MonoBehaviour
{
    int name = 0;

    void Update()
    {
        // 01. ó�� ������ ���� �ƴ��� �Ǵ�
        // ������ �̸��� ����� ���� ���ٸ�
        if (name == 0)
        {
            // ��Ʈ�� ������ �Ѿ.
            SceneManager.LoadScene("04Intro");
        }
    }
}
