using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int ammo;
    
    
    private void OnTriggerEnter(Collider other)
    {
        ammo++;
        print(ammo);
    }
}
