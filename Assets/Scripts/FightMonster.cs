using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FightMonster: MonoBehaviour
{
    [SerializeField] private GameObject aRObject;
    [SerializeField] private GameObject aRObject1;
    [SerializeField] private GameObject aRObject2;
    [SerializeField] private GameObject aRObject3;

    //일반 몬스터 체력
    int monsterHealth = 5;

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

            monsterHealth -= 2;
        }
        else if(currentGesture == ManoGestureTrigger.SWIPE_RIGHT)
        {
            SpawnObject2();

            monsterHealth -= 2;
        }
        else if (currentGesture == ManoGestureTrigger.PICK)
        {
            SpawnObject3();

            monsterHealth -= 2;
        }


        if(monsterHealth <= 0)
        {
            SceneManager.LoadScene("08_2Fight_Win");
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
