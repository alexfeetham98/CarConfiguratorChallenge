using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] cars;
    
    
    public Car currentCar;
    public Engine currentEngine;
    public Bodywork currentBodywork;

    //note for UI - speed, handling, acceleration, braking
    //functionallity - brakes engine turbo respray gearbox 


    void Start()
    {
        currentCar = cars[0].GetComponent<Car>();
        currentEngine = cars[0].GetComponent<Engine>();
        currentBodywork = cars[0].GetComponent<Bodywork>();
    }

    void Update()
    {
        
    }

    public Car GetCar
    {
        get { return currentCar; }
    }

    public Engine GetEngine
    {
        get { return currentEngine; }
    }

    public Bodywork GetBodyWork
    {
        get { return currentBodywork; }
    }
}