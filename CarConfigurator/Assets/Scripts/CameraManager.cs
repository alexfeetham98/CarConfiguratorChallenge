using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private Camera[] cams;

    [SerializeField]
    private Camera activeCam;



    void Start()
    {
        activeCam = cams[0];
    }

    void Update()
    {
        
    }
}
