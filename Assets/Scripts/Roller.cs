using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    public float speed;
    public bool isGlobal;

    void Update()
    {
        // 20�������� 20��, 60�������� 60�� -> �Ȱ��� ���Ӱ���� ���� * Time.deltaTime
        // deltaTime: 1�������� �Һ��� �ð� 
        transform.Rotate(0, speed * Time.deltaTime, 0,
            isGlobal ? Space.World : Space.Self); // y��(global or local)�� �������� speed*Time.deltaTime�� ȸ��
    }
}
