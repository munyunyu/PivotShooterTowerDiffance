using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;
    private PlayerMotor motor;

    void Start()
    {

        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {




        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");
        float _yRot = Input.GetAxisRaw("Mouse X");
        float _xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;
        Vector3 _cameraRotation = new Vector3(_xRot, 0f, 0f) * lookSensitivity;

        motor.Rotate(_rotation);
        motor.RotateCamera(_cameraRotation);
    }
}
