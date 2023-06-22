using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] cars;
    
    
    public Car currentCar;
    public Engine currentEngine;

    //note for UI - speed, handling, acceleration, braking
    //functionallity - brakes engine turbo respray gearbox wheels


    void Start()
    {
        currentCar = cars[0].GetComponent<Car>();
        currentEngine = cars[0].GetComponent<Engine>();
    }

    void Update()
    {
        //currentCar.GetComponent<Car>().engine.
    }

    public Car GetCar
    {
        get { return currentCar; }
    }

    public Engine GetEngine
    {
        get { return currentEngine; }
    }
}