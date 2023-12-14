using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetWantedFlower : MonoBehaviour
{
    public int num;

    private int plantNum;
    private int plantRandomGet;

    private int magicPowerNum;
    private int magicPowerGet;

    void Update()
    {
        // ��ġ �Է� ����
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // ��ġ�� ���۵Ǿ��� ��
            if (touch.phase == TouchPhase.Began)
            {
                // ��ġ ������ ȭ�� ��ǥ�� Ray�� ��ȯ�Ͽ� �浹 �˻�
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    // ��ġ�� ������Ʈ�� ���� ��ũ��Ʈ�� �پ� �ִ� ������Ʈ���
                    if (hit.transform.gameObject == gameObject)
                    {
                        // num�� ���� ���� �ε�
                        switch (num)
                        {
                            case 1:                        
                                plantRandomGet = 10;
                                PlayerPrefs.SetInt("PlantOrangeRandom", plantRandomGet);
                                plantNum = PlayerPrefs.GetInt("PlantOrangeNum"); // PlantOrangeNum�� ����� �� plantNum�� ����
                                PlayerPrefs.SetInt("PlantOrangeNum", plantNum + plantRandomGet); // plantNum + plantRandomGet �� ����� PlantOrangeNum�� ������
                                
                                PlayerPrefs.SetInt("PlantPinkRandom", 0);
                                PlayerPrefs.SetInt("PlantSkyblueRandom", 0);

                                magicPowerGet = 100;// MagicPower ��� �κ�
                                PlayerPrefs.SetInt("MagicPowerGet", magicPowerGet);
                                magicPowerNum = PlayerPrefs.GetInt("MagicPower");
                                PlayerPrefs.SetInt("MagicPower", magicPowerNum + magicPowerGet); 

                                SceneManager.LoadScene("06_9Plant_result");
                                break;
                            case 2:
                                plantRandomGet = 10;
                                PlayerPrefs.SetInt("PlantSkyblueRandom", plantRandomGet);
                                plantNum = PlayerPrefs.GetInt("PlantSkyblueNum"); // PlantSkyblueNum�� ����� �� plantNum�� ����
                                PlayerPrefs.SetInt("PlantSkyblueNum", plantNum + plantRandomGet); // plantNum + plantRandomGet �� ����� PlantSkyblueNum�� ������

                                PlayerPrefs.SetInt("PlantPinkRandom", 0);
                                PlayerPrefs.SetInt("PlantOrangeRandom", 0);

                                magicPowerGet = 100;// MagicPower ��� �κ�
                                PlayerPrefs.SetInt("MagicPowerGet", magicPowerGet);
                                magicPowerNum = PlayerPrefs.GetInt("MagicPower");
                                PlayerPrefs.SetInt("MagicPower", magicPowerNum + magicPowerGet);

                                SceneManager.LoadScene("06_9Plant_result");
                                break;
                            case 3:
                                plantRandomGet = 10;
                                PlayerPrefs.SetInt("PlantPinkRandom", plantRandomGet);
                                plantNum = PlayerPrefs.GetInt("PlantPinkNum"); // PlantPinkNum�� ����� �� plantNum�� ����
                                PlayerPrefs.SetInt("PlantPinkNum", plantNum + plantRandomGet); // plantNum + plantRandomGet �� ����� PlantPinkNum�� ������

                                PlayerPrefs.SetInt("PlantSkyblueRandom", 0);
                                PlayerPrefs.SetInt("PlantOrangeRandom", 0);

                                magicPowerGet = 100;// MagicPower ��� �κ�
                                PlayerPrefs.SetInt("MagicPowerGet", magicPowerGet);
                                magicPowerNum = PlayerPrefs.GetInt("MagicPower");
                                PlayerPrefs.SetInt("MagicPower", magicPowerNum + magicPowerGet);

                                SceneManager.LoadScene("06_9Plant_result");
                                break;
                        }
                    }
                }
            }
        }
    }
}
