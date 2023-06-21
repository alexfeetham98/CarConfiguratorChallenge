using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Engine))]
[RequireComponent(typeof(Wheels))]
public class CarData : MonoBehaviour
{
    private Engine engine;
    
    public enum Turbo { Default, Upgrade1, Upgrade2, Upgrade3 }
    public enum Wheels { Default, Upgrade1, Upgrade2, Upgrade3 }
    public enum Brakes { Default, Upgrade1, Upgrade2, Upgrade3 }
    

    
    [SerializeField]
    private Turbo turbo;
    [SerializeField]
    private Wheels wheels;
    [SerializeField]
    private Brakes brakes;

    void Start()
    {

        turbo = Turbo.Default;
        wheels = Wheels.Default;
        brakes = Brakes.Default;
    }

    void Update()
    {
        
    }
}
