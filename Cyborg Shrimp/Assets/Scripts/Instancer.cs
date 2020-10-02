using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        Instantiate(prefab);
    }
    
}
