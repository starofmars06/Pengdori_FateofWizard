using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shoot : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject explosion;

    RaycastHit hit;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
            {
                if (hit.transform.tag == "Monster")
                {
                    Destroy(hit.transform.gameObject);
                    Instantiate(explosion, hit.transform.position, hit.transform.rotation);
                    Destroy(explosion, 2f);  // nothing gets left behind
                    SceneManager.LoadScene("08_2Fight_Win");
                }
                else if(hit.transform.tag == "Boss")
                {
                    Destroy(hit.transform.gameObject);
                    Instantiate(explosion, hit.transform.position, hit.transform.rotation);
                    Destroy(explosion, 2f);  // nothing gets left behind
                    SceneManager.LoadScene("11_3Win");
                }
            }
        }
    }
}


