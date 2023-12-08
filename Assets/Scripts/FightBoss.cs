using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FightBoss : MonoBehaviour
{
    [SerializeField] private GameObject aRObject;
    [SerializeField] private GameObject aRObject1;
    [SerializeField] private GameObject aRObject2;
    [SerializeField] private GameObject aRObject3;

    //최종보스 체력
    int monsterHealth = 10;

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
        else if(currentGesture == ManoGestureTrigger.GRAB_GESTURE)
        {
            SpawnObject1();

            monsterHealth--;
        }
        else if(currentGesture == ManoGestureTrigger.SWIPE_RIGHT)
        {
            SpawnObject2();

            monsterHealth--;
        }
        else if (currentGesture == ManoGestureTrigger.PICK)
        {
            SpawnObject3();

            monsterHealth--;
        }


        if(monsterHealth <= 0)
        {
            SceneManager.LoadScene("11_3Win");
            Debug.Log("몬스터는 죽었습니다.");
        }


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
