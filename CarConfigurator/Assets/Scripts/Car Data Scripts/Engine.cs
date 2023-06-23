using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    
    [SerializeField][Range(1, 10)]
    private int speed;
    [SerializeField][Range(1, 10)]
    private int acceleration;
    [SerializeField]
    private int engineCost;
    [SerializeField][Range(1, 10)]
    private int turboPower;
    [SerializeField]
    private int turboCost;
    [SerializeField][Range(1, 10)]
    private int gearboxPower;
    [SerializeField]
    private int gearboxCost;
    [SerializeField][Range(1,10)]
    private int brakesPower;
    [SerializeField]
    private int brakesCost;

    
    public enum EngineUpgrades { Stock, Street, Sport, Race }
    public enum TurboUpgrades { Stock, Street, Sport, Race }
    public enum GearboxUpgrades { Stock, Street, Sport, Race }
    public enum BrakesUpgrades { Stock, Street, Sport, Race}
    
    
    public EngineUpgrades engineUpgrades;
    public TurboUpgrades turboUpgrades;
    public GearboxUpgrades gearboxUpgrades;
    public BrakesUpgrades brakesUpgrades;

    void Start()
    {
        engineUpgrades = EngineUpgrades.Stock;
        turboUpgrades = TurboUpgrades.Stock;
        gearboxUpgrades = GearboxUpgrades.Stock;
        brakesUpgrades = BrakesUpgrades.Stock;
    }

    void Update()
    {
        switch (engineUpgrades)
        {
            case EngineUpgrades.Stock:
                speed = 3;
                acceleration = 4;
                engineCost = 0;
                break;
            case EngineUpgrades.Street:
                speed = 4;
                acceleration = 5;
                engineCost = 15000;
                break;
            case EngineUpgrades.Sport:
                speed = 5;
                acceleration = 6;
                engineCost = 25000;
                break;
            case EngineUpgrades.Race:
                speed = 6;
                acceleration = 7;
                engineCost = 40000;
                break;
        }

        switch (turboUpgrades)
        {
            case TurboUpgrades.Stock:
                turboPower = 0;
                turboCost = 0;
                break;
            case TurboUpgrades.Street:
                turboPower = 2;
                turboCost = 5000;
                break;
            case TurboUpgrades.Sport:
                turboPower = 4;
                turboCost = 75000;
                break;
            case TurboUpgrades.Race:
                turboPower = 6;
                turboCost = 12500;
                break;
        }

        switch (gearboxUpgrades)
        {
            case GearboxUpgrades.Stock:
                gearboxPower = 4;
                gearboxCost = 0;
                break;
            case GearboxUpgrades.Street:
                gearboxPower = 5;
                gearboxCost = 5000;
                break;
            case GearboxUpgrades.Sport:
                gearboxPower = 6;
                gearboxCost = 7500;
                break;
            case GearboxUpgrades.Race:
                gearboxPower = 7;
                gearboxCost = 12500;
                break;
        }

        switch (brakesUpgrades)
        {
            case BrakesUpgrades.Stock:
                brakesPower = 3;
                brakesCost = 0;
                break;
            case BrakesUpgrades.Street:
                brakesPower = 5;
                brakesCost = 5000;
                break;
            case BrakesUpgrades.Sport:
                brakesPower = 7;
                brakesCost = 10000;
                break;
            case BrakesUpgrades.Race:
                brakesPower = 9;
                brakesCost = 12500;
                break;
        }
    }


    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int Acceleration
    {
        get { return acceleration; }
        set { acceleration = value; }
    }

    public int EngineCost
    {
        get { return engineCost; }
        set { engineCost = value; }
    }

    public int TurboPower
    {
        get { return turboPower; }
        set { turboPower = value; }
    }

    public int TurboCost
    {
        get { return turboCost; }
        set { turboCost = value; }
    }

    public int GearboxPower
    {
        get { return gearboxPower; }
        set { gearboxPower = value; }
    }

    public int GearboxCost
    {
        get { return gearboxCost; }
        set { gearboxCost = value; }
    }

    public int BrakesPower
    {
        get { return brakesPower; }
        set { brakesPower = value; }
    }

    public int BrakesCost
    {
        get { return brakesCost; }
        set { brakesCost = value; }
    }
}