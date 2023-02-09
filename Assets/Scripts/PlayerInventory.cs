using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfFruits { get; private set; }

    public UnityEvent<PlayerInventory> OnFruitsCollected;

    [SerializeField] private LevelList _levelList;
    

    public void FruitsCollected()
    {
        NumberOfFruits++;
        OnFruitsCollected.Invoke(this);

        if (NumberOfFruits == 6)
        {
            _levelList.GoToNextLevel();
        }
    }
    
    
}
