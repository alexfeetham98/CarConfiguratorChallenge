using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class CameraRig : MonoBehaviour
{
    [SerializeField]
    public Transform focus;
    [SerializeField]
    private Transform target;
    [SerializeField]
    private Transform rig;
    [SerializeField]
    private Transform cam;
    [SerializeField]
    private float aimDistance = 500f;

    public float cameraSensitivity = 0.5f;
    public float cameraSmoothSpeed = 2f;
    public bool enableSmoothFollow = true;
    public float followSmoothSpeed = 10f;
    
    public bool RestrictHorizontal = false;
    public bool RestrictVertical = true;
    
    private bool flightstick = false;

    private float camX;
    private float camY;
    private bool rotatingX = false;
    private bool rotatingY = false;
    
    private void Start()
    {
        ResetPosition();
    }

    public Vector3 targetPosition
    {
        get
        {
            return target.position + (target.forward * aimDistance);
        }
    }
    public Vector3 ReticlePosition
    {
        get
        {
            return focus.position + (focus.forward * aimDistance);
        }
    }

    private void Update()
    {
        UpdatePosition();
        RotateRig();
        ResetPosition();
    }

    void RotateRig()
    {
        float mouseX = 0; float mouseY = 0;
        if (Input.GetMouseButton(1))
        {
            mouseX = Input.GetAxisRaw("Mouse X") * 5;
            mouseY = Input.GetAxisRaw("Mouse Y") * 5;
        }

        if (!RestrictHorizontal)
        {
            camX = (Input.GetAxisRaw("Horizontal") + Input.GetAxisRaw("Right Stick LR") + mouseX) * cameraSensitivity;
            if (camX == 0)
            {
                rotatingX = false;
            }
            else
            {
                rotatingX = true;
            }
        }

        if (!RestrictVertical)
        {
            camY = (Input.GetAxisRaw("Vertical") + Input.GetAxisRaw("Right Stick UD") + mouseY) * cameraSensitivity;
            if (camY == 0)
            {
                rotatingY = false;
            }
            else
            {
                rotatingY = true;
            }
        }
        
        
        //For use with PhantomHawk Joystick
        #region Flightstick Controls
        if (flightstick)
        {
            if (!RestrictHorizontal)
            {
                if (Input.GetKey(KeyCode.JoystickButton3)) //Dpad left - pan right
                {
                    camX = cameraSensitivity * -1;
                    rotatingX = true;
                }
                else if (Input.GetKey(KeyCode.JoystickButton5)) //Dpad right - pan left
                {
                    camX = cameraSensitivity * 1;
                    rotatingX = true;
                }
                else                                            //reset view
                {
                    camX = 0;
                    rotatingX = false;
                }
            }

            if (!RestrictVertical)
            {
                if (Input.GetKey(KeyCode.JoystickButton4)) //Dpad up - pan down
                {
                    camY = cameraSensitivity * -1;
                    rotatingY = true;
                }
                else if (Input.GetKey(KeyCode.JoystickButton6)) //Dpad down - pan up
                {
                    camY = cameraSensitivity * 1;
                    rotatingY = true;
                }
                else                                            //reset view
                {
                    camY = 0;
                    rotatingY = false;
                }
            }
        }
        #endregion
        

        target.Rotate(cam.up, camX, Space.World);
        target.Rotate(cam.right, camY, Space.World);

        Vector3 up = (focus.parent == null) ? Vector3.up : focus.parent.up;

        rig.rotation = Damp(rig.rotation,
                            Quaternion.LookRotation(target.forward, up),
                            cameraSmoothSpeed,
                            Time.deltaTime);
    }

    void UpdatePosition()
    {
        if (focus != null)
        {
            if (enableSmoothFollow)
            {
                transform.position = Damp(transform.position,
                                      focus.position,
                                      followSmoothSpeed,
                                      Time.deltaTime);
            }
            else { transform.position = focus.position; }
        }
    }

    void ResetPosition()
    {
        if (!rotatingX && !rotatingY)
        {
            target.transform.rotation = focus.transform.rotation;
        }
    }

    private Quaternion Damp(Quaternion a, Quaternion b, float lambda, float dt)
    {
        return Quaternion.Slerp(a, b, 1f - Mathf.Exp(-lambda * dt));
    }

    private Vector3 Damp(Vector3 a, Vector3 b, float lambda, float dt)
    {
        return Vector3.Slerp(a, b, 1f - Mathf.Exp(-lambda * dt));
    }
}