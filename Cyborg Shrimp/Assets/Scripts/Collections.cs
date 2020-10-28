using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public List<Collectible> collectibleList;

    private void Start()
    {
        foreach (var item in collectibleList)
        {
            var newItem = new GameObject(item.name);
            var sprite = newItem.AddComponent<SpriteRenderer>();
            sprite.sprite = item.art;
            sprite.color = item.artColor;
        }
    }
}
