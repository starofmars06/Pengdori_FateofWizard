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
        // 터치 입력 감지
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // 터치가 시작되었을 때
            if (touch.phase == TouchPhase.Began)
            {
                // 터치 지점의 화면 좌표를 Ray로 변환하여 충돌 검사
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    // 터치된 오브젝트가 현재 스크립트가 붙어 있는 오브젝트라면
                    if (hit.transform.gameObject == gameObject)
                    {
                        // num에 따라 씬을 로드
                        switch (num)
                        {
                            case 1:                        
                                plantRandomGet = 10;
                                PlayerPrefs.SetInt("PlantOrangeRandom", plantRandomGet);
                                plantNum = PlayerPrefs.GetInt("PlantOrangeNum"); // PlantOrangeNum에 저장된 값 plantNum에 넣음
                                PlayerPrefs.SetInt("PlantOrangeNum", plantNum + plantRandomGet); // plantNum + plantRandomGet 한 결과를 PlantOrangeNum에 저장함
                                
                                PlayerPrefs.SetInt("PlantPinkRandom", 0);
                                PlayerPrefs.SetInt("PlantSkyblueRandom", 0);

                                magicPowerGet = 100;// MagicPower 얻는 부분
                                PlayerPrefs.SetInt("MagicPowerGet", magicPowerGet);
                                magicPowerNum = PlayerPrefs.GetInt("MagicPower");
                                PlayerPrefs.SetInt("MagicPower", magicPowerNum + magicPowerGet); 

                                SceneManager.LoadScene("06_9Plant_result");
                                break;
                            case 2:
                                plantRandomGet = 10;
                                PlayerPrefs.SetInt("PlantSkyblueRandom", plantRandomGet);
                                plantNum = PlayerPrefs.GetInt("PlantSkyblueNum"); // PlantSkyblueNum에 저장된 값 plantNum에 넣음
                                PlayerPrefs.SetInt("PlantSkyblueNum", plantNum + plantRandomGet); // plantNum + plantRandomGet 한 결과를 PlantSkyblueNum에 저장함

                                PlayerPrefs.SetInt("PlantPinkRandom", 0);
                                PlayerPrefs.SetInt("PlantOrangeRandom", 0);

                                magicPowerGet = 100;// MagicPower 얻는 부분
                                PlayerPrefs.SetInt("MagicPowerGet", magicPowerGet);
                                magicPowerNum = PlayerPrefs.GetInt("MagicPower");
                                PlayerPrefs.SetInt("MagicPower", magicPowerNum + magicPowerGet);

                                SceneManager.LoadScene("06_9Plant_result");
                                break;
                            case 3:
                                plantRandomGet = 10;
                                PlayerPrefs.SetInt("PlantPinkRandom", plantRandomGet);
                                plantNum = PlayerPrefs.GetInt("PlantPinkNum"); // PlantPinkNum에 저장된 값 plantNum에 넣음
                                PlayerPrefs.SetInt("PlantPinkNum", plantNum + plantRandomGet); // plantNum + plantRandomGet 한 결과를 PlantPinkNum에 저장함

                                PlayerPrefs.SetInt("PlantSkyblueRandom", 0);
                                PlayerPrefs.SetInt("PlantOrangeRandom", 0);

                                magicPowerGet = 100;// MagicPower 얻는 부분
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
