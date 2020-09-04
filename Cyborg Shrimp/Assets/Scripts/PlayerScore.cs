using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public float speed = 5f;
    public int score = 100;
    public string password = "password";
    public float health = 3;
   
   private void Update()
   {
       var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
       var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(x:hInput, y:vInput, z:0);
    }
}