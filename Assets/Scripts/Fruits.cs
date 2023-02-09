using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    
    // private AudioSource _audioSource;
    //
    // public AudioClip pickUpSeeds;
    
    // void Start()
    // {
    //     _audioSource = GetComponent<AudioSource>();
    // }
    private void OnTriggerEnter2D(Collider2D col)
    {
        PlayerInventory playerInventory = col.GetComponent<PlayerInventory>();

        // if (col.gameObject.CompareTag("Player"))
        // {
        //     _audioSource.clip = pickUpSeeds;
        //     _audioSource.Play();
        // }

        if (playerInventory != null)
        {
            playerInventory.FruitsCollected();
            gameObject.SetActive(false);
        }
    }
}
