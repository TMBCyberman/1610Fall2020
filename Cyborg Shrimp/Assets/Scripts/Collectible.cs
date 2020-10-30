using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collectible : ScriptableObject
{
    public int cashValue = 10;
    public Sprite art;
    public Color artColor = Color.blue;
}
