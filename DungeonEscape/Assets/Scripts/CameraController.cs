using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float sensitivity = 100.0f;
    public Transform player;

    float xRotation, yRotation = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // blokowanie kursora myszy w œrodku ekranu
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0.0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
