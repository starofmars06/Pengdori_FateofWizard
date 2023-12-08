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

    public Text healthText; // UI Text ������Ʈ�� �ν����Ϳ��� ����
    public Text infoText;

    public Text potion1;
    public Text potion2;
    public Text potion3;

    //���� ���� ����;
    int MagicPotion1;
    int MagicPotion2;
    int MagicPotion3;

    //�������� ü��
    int monsterHealth = 10;

    void Start()
    {
        ChangeInfoText();

        // �� ó���� ��⿡ ����Ǿ��ִ� ���� �� �� ��������
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

        //���� ���� ���� ������ 1�� �̻��� ���� ����
        if (MagicPotion1 > 0)
        {
            if (currentGesture == ManoGestureTrigger.GRAB_GESTURE)
            {
                SpawnObject1();

                monsterHealth -= 2;
                MagicPotion1--;
            }
        }

        //���� ���� ���� ������ 1�� �̻��� ���� ����
        if (MagicPotion2 > 0)
        {
            if (currentGesture == ManoGestureTrigger.SWIPE_RIGHT)
            {
                SpawnObject2();

                monsterHealth -= 2;
                MagicPotion2--;
            }
        }

        //���� ���� ���� ������ 1�� �̻��� ���� ����
        if (MagicPotion3 > 0)
        {
            if (currentGesture == ManoGestureTrigger.PICK)
            {
                SpawnObject3();

                monsterHealth -= 2;
                MagicPotion3--;
            }
        }


        //���� ü���� 0�� �Ǹ� �̵���.
        if (monsterHealth <= 0)
        {
            SceneManager.LoadScene("11_3Win");
        }

        UpdateHealthUI(); // �� �����Ӹ��� ü���� ������Ʈ
        UpdatePotionUI();   //�� �����Ӹ��� ����� ���� Ȯ���ϰ� ������Ʈ


    }

    void ChangeInfoText()
    {
        infoText.text = "�յ����� �̿��� �������� ���� ���̼���.";
    }

    // UI Text ������Ʈ
    void UpdateHealthUI()
    {
        healthText.text = "���� ü��: " + monsterHealth.ToString();
    }

    void UpdatePotionUI()
    {
        potion1.text = "����: " + MagicPotion1.ToString();
        potion2.text = "����: " + MagicPotion2.ToString();
        potion3.text = "����: " + MagicPotion3.ToString();

    }

    //ù��° ����
    private void SpawnObject()
    {
        ManomotionManager.Instance.ShouldCalculateSkeleton3D(true);

        TrackingInfo trackingInfo = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info;

        float depthEstimation = trackingInfo.depth_estimation;

        Vector3 jointPosition = ManoUtils.Instance.CalculateNewPositionSkeletonJointDepth(new Vector3(trackingInfo.skeleton.joints[8].x, trackingInfo.skeleton.joints[8].y, trackingInfo.skeleton.joints[8].z), depthEstimation);

        Instantiate(aRObject, jointPosition, Quaternion.identity);



        Handheld.Vibrate();
    }

    //�ι�° ����
    private void SpawnObject1()
    {
        ManomotionManager.Instance.ShouldCalculateSkeleton3D(true);

        TrackingInfo trackingInfo = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info;

        float depthEstimation = trackingInfo.depth_estimation;

        Vector3 jointPosition = ManoUtils.Instance.CalculateNewPositionSkeletonJointDepth(new Vector3(trackingInfo.skeleton.joints[8].x, trackingInfo.skeleton.joints[8].y, trackingInfo.skeleton.joints[8].z), depthEstimation);

        Instantiate(aRObject1, jointPosition, Quaternion.identity);



        Handheld.Vibrate();
    }

    //����° ����
    private void SpawnObject2()
    {
        ManomotionManager.Instance.ShouldCalculateSkeleton3D(true);

        TrackingInfo trackingInfo = ManomotionManager.Instance.Hand_infos[0].hand_info.tracking_info;

        float depthEstimation = trackingInfo.depth_estimation;

        Vector3 jointPosition = ManoUtils.Instance.CalculateNewPositionSkeletonJointDepth(new Vector3(trackingInfo.skeleton.joints[8].x, trackingInfo.skeleton.joints[8].y, trackingInfo.skeleton.joints[8].z), depthEstimation);

        Instantiate(aRObject2, jointPosition, Quaternion.identity);



        Handheld.Vibrate();
    }

    //�׹�° ����
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
