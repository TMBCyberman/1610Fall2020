using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clout : MonoBehaviour
{
    public int clout;
    
    
    private void OnTriggerEnter(Collider other)
    {
        clout++;
        print(clout);
    }
}
