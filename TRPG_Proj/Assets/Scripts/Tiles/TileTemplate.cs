using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTemplate : MonoBehaviour
{
    [SerializeField] private CameraScript camScript;
    [SerializeField] protected GameObject indiPlane;

    private void Awake()
    {
        camScript = FindObjectOfType<CameraScript>();
    }

    void OnMouseEnter()
    {
        if (camScript.isRotatingCam == false)
        {
            indiPlane.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        indiPlane.SetActive(false);
    }
}
