using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public static UnitManager Instance;
    private List<ScriptableUnit> units;

    public BaseHero selectedHero;
    private void Awake()
    {
        Instance = this;

        units = Resources.LoadAll<ScriptableUnit>("Units").ToList();
    }

    public void SetSelectedHero(BaseHero hero)
    {
        selectedHero = hero;
    }
    
}
