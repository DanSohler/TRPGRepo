using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTemplate : MonoBehaviour
{
    [SerializeField] protected GameObject indiPlane;
    void OnMouseEnter()
    {
        indiPlane.SetActive(true);
    }

    void OnMouseExit()
    {
        indiPlane.SetActive(false);
    }
}
