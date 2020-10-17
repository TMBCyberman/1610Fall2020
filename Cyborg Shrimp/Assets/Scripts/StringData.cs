﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu]
public class StringData : ScriptableObject
{
    public string value;

    public void DisplayText(Text txt)
    {
        txt.text = value.ToString();
    }
}