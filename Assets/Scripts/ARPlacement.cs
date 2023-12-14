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
        // ARRaycastManager�� ã�ƿͼ� �Ҵ�
        aRRaycastManager = FindObjectOfType<ARRaycastManager>();

        // ó���� ���ݻ��� ��Ȱ��ȭ
        magic.SetActive(false);
        //timer.SetActive(false);

    }


    void Update()
    {
        // ��ġ �Է��� �����Ǹ� ���͸� �����ϰ� ���� ���� Ȱ��ȭ
        if (spawnedObject == null && placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ARPlaceObject(); // ���� ����
            magic.SetActive(true); // ���� ���� Ȱ��ȭ
            //timer.SetActive(true);  //Ÿ�̸� ���� Ȱ��ȭ
        }

        // ��ġ ��ġ ����ϱ�
        UpdatePlacementPose();
        UpdatePlacementIndicator();
    }

    // ��Ŀ(������) ������Ʈ
    void UpdatePlacementIndicator()
    {
        // ������ ARObject�� ����, ��ġ ��� ��ȿ�ϸ� ��ġ �����ڸ� �ش� ��ġ�� ȸ������ ����
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

    // ��ġ ��ġ�� ������Ʈ
    void UpdatePlacementPose()
    {
        // ȭ�� �߾��� �������� Ray�� ��� ARRaycastManager�� ����Ͽ� AR ����� ����
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        aRRaycastManager.Raycast(screenCenter, hits, TrackableType.Planes);

        // AR ����� �����Ǿ����� ��ġ ��ġ�� ����
        placementPoseIsValid = hits.Count > 0;
        if (placementPoseIsValid)
        {
            PlacementPose = hits[0].pose;
        }
    }

    // ���͸� �����ϰ� �÷��̾ ���ϵ��� ȸ����Ű�� �޼���
    void ARPlaceObject()
    {
        // �÷��̾� ��ġ�� �������� ARObject�� ���ϵ��� ȸ�� ���
        Vector3 toPlayer = Camera.main.transform.position - PlacementPose.position;
        toPlayer.y = 0;
        Quaternion rotationToPlayer = Quaternion.LookRotation(toPlayer);

        // ARObject�� �����ϰ� ȸ���� ����
        spawnedObject = Instantiate(arObjectToSpawn, PlacementPose.position, rotationToPlayer);
    }
}
