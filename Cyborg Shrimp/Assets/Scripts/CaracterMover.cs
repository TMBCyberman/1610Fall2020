﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracterMover : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 3f, gravity = -9.81f, jumpForce = 30f;
    
    private Vector3 moveDirection;
    private float yDirection;
    private void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        moveDirection.Set(moveSpeedInput, yDirection, 0);

        yDirection += gravity * Time.deltaTime;

        if (controller.isGrounded && moveDirection.y < 0)
        {
            yDirection = -1f;
        }
        
        if (Input.GetButton("Jump"))
        {
            moveDirection.y = jumpForce;
        }
        
        controller.Move(moveDirection * Time.deltaTime);
    }
}