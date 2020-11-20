using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVariables : ScriptableObject
{
    public bool godtierance = false;
    public float boon = 0f;
    public float grist = 0f;
    public float pluck = 0f;
    public int vial = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        do
        {
            vial = 9999999;
        } 
        while (godtierance == true);
    }
}
