using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{

    [SerializeField]
    private Camera cam;

    private Vector3 velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;
    private Vector3 cameraRotation = Vector3.zero;
    private Rigidbody rb;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }
    //x-axis
    public void Rotate(Vector3 _rotation)
    {

        rotation = _rotation;
    }

    public void RotateCamera(Vector3 _cameraRotation)
    {

        cameraRotation = _cameraRotation;
    }

    void FixedUpdate()
    {

        PerformRotation();

    }

    void PerformRotation()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));

        if (cam != null)
        {
            cam.transform.Rotate(-cameraRotation);
        }
    }
}
