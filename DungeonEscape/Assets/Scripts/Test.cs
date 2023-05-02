using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private CharacterController controller;
    public float gravity = -9.81f;
    Vector3 velocity;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xAxis + transform.forward * yAxis;
        controller.Move(move * 12f);
    }
}
