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

    private void OnMouseDown()
    {
        if (GameManager.Instance.State != GameStates.PlayerRound) return;

        if (occupiedUnit != null)
        {
            if(occupiedUnit.faction == Faction.Hero) UnitManager.Instance.SetSelectedHero((BaseHero)occupiedUnit);
            else
            {
                if (UnitManager.Instance.selectedHero != null)
                {
                    // pSelects enemy in space
                    var enemy = (BaseEnemy)occupiedUnit;
                    // put playre attacks here against enemy
                    UnitManager.Instance.SetSelectedHero(null);
                }
            }
        }
        else
        {
            if (UnitManager.Instance.selectedHero != null)
            {
                SetUnit(UnitManager.Instance.selectedHero);
                UnitManager.Instance.SetSelectedHero(null);
            }
        }

    }


    public void SetUnit(UnitTemplate unit)
    {
        if (unit.occupiedTile != null) unit.occupiedTile.occupiedUnit = null;
        unit.transform.position = transform.position;
        occupiedUnit = unit;
        unit.occupiedTile = this;
    }

}
