using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaneManager : MonoBehaviour
{
    public GameObject Cauldron;
    public GameObject RedCube;
    public GameObject YellowCube;
    public GameObject BlueCube;

    ARRaycastManager arManager;

    void DetectGround()
    {
        Vector2 screenSize = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

        List<ARRaycastHit> hitInfos = new List<ARRaycastHit>();
        if (arManager.Raycast(screenSize, hitInfos, TrackableType.Planes))
        {
            Cauldron.SetActive(true);
            Cauldron.transform.position = hitInfos[0].pose.position;
            Cauldron.transform.rotation = hitInfos[0].pose.rotation;
            RedCube.SetActive(true);
            YellowCube.SetActive(true);
            BlueCube.SetActive(true);
            RedCube.transform.position = new Vector3(Cauldron.transform.position.x, Cauldron.transform.position.y + 0.3f, Cauldron.transform.position.z - 2);
            BlueCube.transform.position = new Vector3(Cauldron.transform.position.x + 1, Cauldron.transform.position.y + 0.5f, Cauldron.transform.position.z - 1.5f);
            RedCube.transform.position = new Vector3(Cauldron.transform.position.x - 1, Cauldron.transform.position.y + 0.5f, Cauldron.transform.position.z - 1.5f);
        }
        else
        {
            Cauldron.SetActive(false);
            RedCube.SetActive(false);
            YellowCube.SetActive(false);
            BlueCube.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Cauldron.SetActive(false);
        RedCube.SetActive(false);
        YellowCube.SetActive(false);
        BlueCube.SetActive(false);

        arManager = GetComponent<ARRaycastManager>();

    }

    // Update is called once per frame
    void Update()
    {
        DetectGround();
    }
}
