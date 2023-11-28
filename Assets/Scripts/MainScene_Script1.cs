using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene_Script1 : MonoBehaviour
{
    int name = 0;

    void Update()
    {
        // 01. 처음 접속한 건지 아닌지 판단
        // 이전에 이름을 기록한 적이 없다면
        if (name == 0)
        {
            // 인트로 씬으로 넘어감.
            SceneManager.LoadScene("04Intro");
        }
    }
}
