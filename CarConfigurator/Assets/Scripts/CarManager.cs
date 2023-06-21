using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] cars;
    
    
    private CarData currentCar;
    
    
    void Start()
    {
        currentCar = cars[0].GetComponent<CarData>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}