using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

   
    [SerializeField] private float speed = 5;
    [SerializeField] private float MouseSensitivity = 3;
    [SerializeField] private float JumpForce = 1000;


    public bool CanRun = true;
    public bool Frozen;




    private PlayerMotor motor;

	void Start()
	{
        motor = gameObject.GetComponent<PlayerMotor>();
        Cursor.lockState = CursorLockMode.Locked;

	}

    void Update()
    {
        //calculate movement velocity as a 3D vector
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");
        Vector3 _movHorizontal = transform.right * _xMov;
        Vector3 _movVertical = transform.forward * _zMov;

        float _speed;

        if (CanRun)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _speed = speed * 2;

            }
            else
            {
                _speed = speed;

            }
        }
            else
            {
                _speed = speed;
                
            }
        

       

        //final vector ! :D
        Vector3 _Velocity = (_movHorizontal + _movVertical).normalized * _speed;
        //MOVE!!!!!!!!
        motor.Move(_Velocity);


        //calculate rotation as a 3D vector (turning around)
        float _yRot = Input.GetAxisRaw("Mouse X") / Time.deltaTime;
        Vector3 _rotation = new Vector3(0, _yRot, 0) * MouseSensitivity;
        //apply
        motor.Rotate(_rotation);

        //calculate camera rotation as a 3D vector (up down)
        float _xRot = Input.GetAxisRaw("Mouse Y") / Time.deltaTime;
        float _cameraRotationX = _xRot * MouseSensitivity;
        //apply
        motor.RotateCamera(_cameraRotationX);

        //print(CurrentThrusterTime);



        Vector3 _ThrusterForce = Vector3.zero;

        //apply thruster force
        if (Input.GetButtonDown("Jump"))
        {
            if (IsGrounded())
            {
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0));
            }
        }
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, 1.1f);
    }



}
