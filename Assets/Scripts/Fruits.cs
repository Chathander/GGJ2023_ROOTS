using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        PlayerInventory playerInventory = col.GetComponent<PlayerInventory>();
    
        if (playerInventory != null)
        {
            playerInventory.FruitsCollected();
            gameObject.SetActive(false);
        }
    }
}
