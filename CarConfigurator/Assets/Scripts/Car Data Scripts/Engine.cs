using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    private int value = 0;
    private int speed = 3;
    private int acceleration = 4;

    public enum EngineUpgrades { Default, Upgrade1, Upgrade2, Upgrade3 }
    public enum TurboUpgrades { Default, Upgrade1, Upgrade2, Upgrade3 }

    [SerializeField]
    private EngineUpgrades engineUpgrades;
    [SerializeField]
    private TurboUpgrades turboUpgrades;

    void Start()
    {
        engineUpgrades = EngineUpgrades.Default;
        turboUpgrades = TurboUpgrades.Default;
    }

    void Update()
    {

    }
}