using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 _moveDirection;
    public void Update()
    {
        if (Input.GetButton("Jump"))
        {
            _moveDirection.x = moveSpeed * Time.deltaTime;
        }
        else
        {
            _moveDirection.x = -moveSpeed * Time.deltaTime;
        }
        transform.Translate(_moveDirection);

    }
}
