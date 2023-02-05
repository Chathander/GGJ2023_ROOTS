using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfFruits { get; private set; }

    public UnityEvent<PlayerInventory> OnFruitsCollected;

    public void FruitsCollected()
    {
        NumberOfFruits++;
        OnFruitsCollected.Invoke(this);
    }
}
