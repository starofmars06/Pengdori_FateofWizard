using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MultiImageTracker : MonoBehaviour
{
    private ARTrackedImageManager trackedImageManager;

    [SerializeField]
    private GameObject[] placeablePrefabs;

    private Dictionary<string, GameObject> spawnedObject;

    private void Awake()
    {
        trackedImageManager = GetComponent<ARTrackedImageManager>();
        spawnedObject = new Dictionary<string, GameObject>();

        foreach (GameObject obj in placeablePrefabs)
        {
            GameObject newObject = Instantiate(obj);
            newObject.name = obj.name;
            newObject.SetActive(false);

            spawnedObject.Add(newObject.name, newObject);
        }
    }

    private void OnEnable() 
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImageChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImageChanged;
    }

    void OnTrackedImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            UpdateSpawnObject(trackedImage);
        }

        foreach (ARTrackedImage trackedImage in eventArgs.updated)
        {
            UpdateSpawnObject(trackedImage);
        }

        foreach (ARTrackedImage trackedImage in eventArgs.removed)
        {
            spawnedObject[trackedImage.name].SetActive(false);
        }
    }

    void UpdateSpawnObject(ARTrackedImage trackedImage)
    {
        string referenceImageName =  trackedImage.referenceImage.name;

        spawnedObject[referenceImageName].transform.position = trackedImage.transform.position;
        spawnedObject[referenceImageName].transform.rotation = trackedImage.transform.rotation;

        spawnedObject[referenceImageName].SetActive(true);
    }
}
