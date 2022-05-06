using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTemplate : MonoBehaviour
{
    [SerializeField] private CameraScript camScript;
    [SerializeField] protected GameObject indiPlane;
    [SerializeField] private bool isWalkable;
    public UnitTemplate occupiedUnit;

    public bool Walkable => isWalkable && occupiedUnit == null;

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
