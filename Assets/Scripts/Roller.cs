using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    public float speed;
    public bool isGlobal;

    void Update()
    {
        // 20프레임은 20번, 60프레임은 60번 -> 똑같은 게임결과를 위해 * Time.deltaTime
        // deltaTime: 1프레임이 소비한 시간 
        transform.Rotate(0, speed * Time.deltaTime, 0,
            isGlobal ? Space.World : Space.Self); // y축(global or local)을 기준으로 speed*Time.deltaTime로 회전
    }
}
