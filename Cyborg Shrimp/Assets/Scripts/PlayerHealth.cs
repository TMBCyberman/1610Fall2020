using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public float speed = 5f;
    public int score = 100;
    
    private void Update()
    {
        transform.Translate(x:speed*Time.deltaTime, y:0, z:0);
    }
}
