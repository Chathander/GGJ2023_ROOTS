using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCurrentLevel : MonoBehaviour
{
    [SerializeField] private LevelList _levelList;

    //Hack that lets us use the levelList correctly even when "jumping" to any random level in the unity editor.
    
    void Start()
    {
        _levelList.SetCurrentLevelFromActiveScene();
    }

}
