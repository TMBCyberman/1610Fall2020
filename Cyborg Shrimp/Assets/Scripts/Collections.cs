using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public string singleString;
    public List<Collectible> collectionlist;

    public void Start()
    {
        foreach (var item in collectionlist)
        {
            var newItem = new GameObject(item.name);
            var sprite = newItem.AddComponent<SpriteRenderer>();
            sp
        }
    }
}
