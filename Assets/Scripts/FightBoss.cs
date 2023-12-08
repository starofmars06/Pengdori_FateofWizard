using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FightBoss : MonoBehaviour
{
    [SerializeField] private GameObject aRObject;
    [SerializeField] private GameObject aRObject1;
    [SerializeField] private GameObject aRObject2;
    [SerializeField] private GameObject aRObject3;

    public Text healthText; // UI Text 오브젝트를 인스펙터에서 연결
    public Text infoText;

    public Text potion1;
    public Text potion2;
    public Text potion3;

    //마법 물약 개수;
    int MagicPotion1;
    int MagicPotion2;
    int MagicPotion3;

    //최종보스 체력
    int monsterHealth = 10;

    void Start()
    {
        ChangeInfoText();

        // 맨 처음에 기기에 저장되어있는 포션 총 수 가져오기
        MagicPotion1 = PlayerPrefs.GetInt("Potion1");
        MagicPotion2 = PlayerPrefs.GetInt("Potion2");
        MagicPotion3 = PlayerPrefs.GetInt("Potion3");
    }

    // Update is called once per frame
    void Update()
    {
        ManomotionManager.Instance.ShouldCalculateGestures(true);

        GestureInfo gestureInfo = ManomotionManager.Instance.Hand_infos[0].hand_info.gesture_info;
        ManoGestureTrigger currentGesture = gestureInfo.mano_gesture_trigger;


        if (currentGesture == ManoGestureTrigger.CLICK)
        {
            SpawnObject();
            monsterHealth--;
        }

        //별빛 마법 약의 갯수가 1개 이상일 때만 실행
        if (MagicPotion1 > 0)
        {
            if (currentGesture == ManoGestureTrigger.GRAB_GESTURE)
            {
                SpawnObject1();

                monsterHealth -= 2;
                MagicPotion1--;
            }
        }

        //전기 마법 약의 갯수가 1개 이상일 때만 실행
        if (MagicPotion2 > 0)
        {
            if (currentGesture == ManoGestureTrigger.SWIPE_RIGHT)
            {
                SpawnObject2();

                monsterHealth -= 2;
                MagicPotion2--;
            }
        }

        //포털 마법 약의 개수가 1개 이상일 때만 실행
        if (MagicPotion3 > 0)
        {
            if (currentGesture == ManoGestureTrigger.PICK)
            {
                SpawnObject3();

                monsterHealth -= 2;
                MagicPotion3--;
            }
        }


        //몬스터 체력이 0이 되면 이동함.
        if (monsterHealth <= 0)
        {
            SceneManager.LoadScene("11_3Win");
        }

        UpdateHealthUI(); // 매 프레임마다 체력을 업데이트
        UpdatePotionUI();   //매 프레임마다 사용한 포션 확인하고 업데이트


    }

    void ChangeInfoText()
    {
        infoText.text = "손동작을 이용해 마법으로 적을 죽이세요.";
    }

    // UI Text 업데이트
    void UpdateHealthUI()
    {
        healthText.text = "보스 체력: " + monsterHealth.ToString();
    }

    void UpdatePotionUI()
    {
        potion1.text = "별빛: " + MagicPotion1.ToString();
        potion2.text = "전기: " + MagicPotion2.ToString();
        potion3.text = "포털: " + MagicPotion3.ToString();

    }

    //첫번째 마법
    private void SpawnObject()
    {
        ManomotionManager.Instance.ShouldCalculateSkeleton3D(true);

        TrackingInfo trackingInfo = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info;

        float depthEstimation = trackingInfo.depth_estimation;

        Vector3 jointPosition = ManoUtils.Instance.CalculateNewPositionSkeletonJointDepth(new Vector3(trackingInfo.skeleton.joints[8].x, trackingInfo.skeleton.joints[8].y, trackingInfo.skeleton.joints[8].z), depthEstimation);

        Instantiate(aRObject, jointPosition, Quaternion.identity);



        Handheld.Vibrate();
    }

    //두번째 마법
    private void SpawnObject1()
    {
        ManomotionManager.Instance.ShouldCalculateSkeleton3D(true);

        TrackingInfo trackingInfo = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info;

        float depthEstimation = trackingInfo.depth_estimation;

        Vector3 jointPosition = ManoUtils.Instance.CalculateNewPositionSkeletonJointDepth(new Vector3(trackingInfo.skeleton.joints[8].x, trackingInfo.skeleton.joints[8].y, trackingInfo.skeleton.joints[8].z), depthEstimation);

        Instantiate(aRObject1, jointPosition, Quaternion.identity);



        Handheld.Vibrate();
    }

    //세번째 마법
    private void SpawnObject2()
    {
        ManomotionManager.Instance.ShouldCalculateSkeleton3D(true);

        TrackingInfo trackingInfo = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info;

        float depthEstimation = trackingInfo.depth_estimation;

        Vector3 jointPosition = ManoUtils.Instance.CalculateNewPositionSkeletonJointDepth(new Vector3(trackingInfo.skeleton.joints[8].x, trackingInfo.skeleton.joints[8].y, trackingInfo.skeleton.joints[8].z), depthEstimation);

        Instantiate(aRObject2, jointPosition, Quaternion.identity);



        Handheld.Vibrate();
    }

    //네번째 마법
    private void SpawnObject3()
    {
        ManomotionManager.Instance.ShouldCalculateSkeleton3D(true);

        TrackingInfo trackingInfo = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info;

        float depthEstimation = trackingInfo.depth_estimation;

        Vector3 jointPosition = ManoUtils.Instance.CalculateNewPositionSkeletonJointDepth(new Vector3(trackingInfo.skeleton.joints[8].x, trackingInfo.skeleton.joints[8].y, trackingInfo.skeleton.joints[8].z), depthEstimation);

        Instantiate(aRObject3, jointPosition, Quaternion.identity);



        Handheld.Vibrate();
    }
}
