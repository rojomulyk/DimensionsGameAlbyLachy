using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{


    [SerializeField] private float cameraRotationLimit = 85;
    public Camera cam;
    private ConfigurableJoint joint;

    private Vector3 rotation = Vector3.zero;
    private Vector3 velocity = Vector3.zero;
    private float cameraRotationX = 0;
    private float CurrentXrotation;
    private Vector3 ThrusterForce = Vector3.zero;
    private Rigidbody rb;






    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        joint = gameObject.GetComponent<ConfigurableJoint>();
       
    }
    public void Rotate(Vector3 _rotation)
    {
        rotation = _rotation;
    }
    public void ApplyThruster(Vector3 _thrusterForce)
    {
        ThrusterForce = _thrusterForce;
    }
    public void RotateCamera(float _CameraRotation)
    {
        cameraRotationX = _CameraRotation;
    }
    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    void FixedUpdate()
    {
        PeformMovement();
        PeformRotation();
    }

    void PeformMovement()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(transform.position + velocity * Time.fixedDeltaTime);
        }
        if (ThrusterForce != Vector3.zero)
        {
            rb.AddForce(ThrusterForce * Time.fixedDeltaTime, ForceMode.Acceleration);
           
        }
       
    }

    void PeformRotation()
    {
        rb.MoveRotation(transform.rotation * Quaternion.Euler(rotation));
        if (cam != null)
        {
            //set rotation
            CurrentXrotation -= cameraRotationX;
            //clamp it
            CurrentXrotation = Mathf.Clamp(CurrentXrotation, -cameraRotationLimit, cameraRotationLimit);

            cam.transform.localEulerAngles = new Vector3(CurrentXrotation, 0, 0);
        }

    }






}
