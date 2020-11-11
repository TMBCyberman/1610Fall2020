using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Defenses : ScriptableObject
{
    public enum DefenseItems
    {
        Shield,
        Potions,
        ExtraHealth,
        Buffs,
        SuperShield
    }

    public DefenseItems currentDefense;

    public void RunCurrentDefense()
    {
        switch (currentDefense)
        {
            case DefenseItems.Shield:
                //function 
                break;
            case DefenseItems.Potions:
                //function 
                break;
            case DefenseItems.ExtraHealth:
                //function 
                break;
            case DefenseItems.Buffs:
                //function 
                break;
            case DefenseItems.SuperShield:
                //function 
                break;
        }
    }
}