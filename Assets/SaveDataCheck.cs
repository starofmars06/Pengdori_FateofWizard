using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void awake()
    {
        if (!PlayerPrefs.HasKey("SaveData")) // (�� ����̽��� SaveData�� �ѹ��̶� ������ ���� �ִ°�)�� �ݴ�
        {
            PlayerPrefs.SetInt("SaveData", 0); // �� ����̽��� SaveData�� ������ ���� ���ٸ� 0 ����
        }
    }
}
