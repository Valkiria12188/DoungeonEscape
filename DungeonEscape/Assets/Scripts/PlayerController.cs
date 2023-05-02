using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public float gravity = -9.81f;
    [SerializeField] private float moveSpeed;

    Vector3 velocity;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xAxis + transform.forward * yAxis;
        controller.Move(move * moveSpeed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity *Time.deltaTime);
    }

}
