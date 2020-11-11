using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Defense : ScriptableObject
{
    public float powerLevel = 0.5f;
    public GameObject art;
    public Color defenseColor;

    public void UseDefense()
    {
        //use defense
    }
}
