using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Arsenal : ScriptableObject
{
    public enum Weapons
    {
        HammerKind,
        BowlingPinKind,
        BoomerangKind,
        JokerKind
    }

    public Weapons currentSpecibus;

    public void RunCurrentSpecibus()
    {
        switch (currentSpecibus)
        {
            case Weapons.HammerKind:
                //function 
                break;
            case Weapons.BowlingPinKind:
                //function 
                break;
            case Weapons.BoomerangKind:
                //function 
                break;
            case Weapons.JokerKind:
                //function 
                break;

        }
    }
}