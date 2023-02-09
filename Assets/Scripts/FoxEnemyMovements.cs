using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxEnemyMovements : MonoBehaviour
{
    [SerializeField] private LevelList _levelList;

    
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
                {
                    _levelList.RestartLevel();
                }
            

        }
       


    

}