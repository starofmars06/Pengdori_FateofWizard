using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARPlacement : MonoBehaviour
{
    public GameObject arObjectToSpawn;
    public GameObject placementIndicator;
    public GameObject magic;
    //public GameObject timer;

    private Pose PlacementPose;
    private GameObject spawnedObject;
    private ARRaycastManager aRRaycastManager;
    private bool placementPoseIsValid = false;


    void Start()
    {
        // ARRaycastManager를 찾아와서 할당
        aRRaycastManager = FindObjectOfType<ARRaycastManager>();

        // 처음에 공격상태 비활성화
        magic.SetActive(false);
        //timer.SetActive(false);

    }


    void Update()
    {
        // 터치 입력이 감지되면 몬스터를 생성하고 공격 상태 활성화
        if (spawnedObject == null && placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ARPlaceObject(); // 몬스터 생성
            magic.SetActive(true); // 공격 상태 활성화
            //timer.SetActive(true);  //타이머 상태 활성화
        }

        // 배치 위치 계산하기
        UpdatePlacementPose();
        UpdatePlacementIndicator();
    }

    // 마커(마법진) 업데이트
    void UpdatePlacementIndicator()
    {
        // 생성된 ARObject가 없고, 배치 포즈가 유효하면 배치 지시자를 해당 위치와 회전으로 설정
        if (spawnedObject == null && placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(PlacementPose.position, PlacementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }

    // 배치 위치를 업데이트
    void UpdatePlacementPose()
    {
        // 화면 중앙을 기준으로 Ray를 쏘아 ARRaycastManager를 사용하여 AR 평면을 감지
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        aRRaycastManager.Raycast(screenCenter, hits, TrackableType.Planes);

        // AR 평면이 감지되었으면 배치 위치를 설정
        placementPoseIsValid = hits.Count > 0;
        if (placementPoseIsValid)
        {
            PlacementPose = hits[0].pose;
        }
    }

    // 몬스터를 생성하고 플레이어를 향하도록 회전시키는 메서드
    void ARPlaceObject()
    {
        // 플레이어 위치를 기준으로 ARObject를 향하도록 회전 계산
        Vector3 toPlayer = Camera.main.transform.position - PlacementPose.position;
        toPlayer.y = 0;
        Quaternion rotationToPlayer = Quaternion.LookRotation(toPlayer);

        // ARObject를 생성하고 회전을 적용
        spawnedObject = Instantiate(arObjectToSpawn, PlacementPose.position, rotationToPlayer);
    }
}
