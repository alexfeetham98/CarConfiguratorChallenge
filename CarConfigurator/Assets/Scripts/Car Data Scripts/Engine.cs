using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    
    [SerializeField][Range(1, 10)]
    private int speed = 3;
    [SerializeField][Range(1, 10)]
    private int acceleration = 4;
    [SerializeField]
    private int engineCost = 0;
    [SerializeField]
    private int turboPower = 0;
    [SerializeField]
    private int turboCost = 0;
    

    
    public enum EngineUpgrades { Stock, Street, Sport, Race }
    public enum TurboUpgrades { Stock, Street, Sport, Race }
    
    
    public EngineUpgrades engineUpgrades;
    public TurboUpgrades turboUpgrades;

    void Start()
    {
        engineUpgrades = EngineUpgrades.Stock;
        turboUpgrades = TurboUpgrades.Stock;
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

    public int TurboCost
    {
        get { return turboCost; }
        set { turboCost = value; }
    }
}