using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Level List", menuName = "My Menu/Level List", order = 0)]
public class LevelList :  ScriptableObject
{
    public int CurrentLevel = 0;
    public List<string> levels;
    public void SetCurrentLevelFromActiveScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        CurrentLevel = levels.IndexOf(currentSceneName);
    }
    public void GoToNextLevel()
    {
        CurrentLevel++;
        if (CurrentLevel >= levels.Count)
        {
            
            // You win!
            //loop back to start.
            CurrentLevel = 0; //0;

        }

        SceneManager.LoadScene(levels[CurrentLevel]);
        
    }

    
    
    public void GoBackLevel()
    {
        CurrentLevel--;
        if (CurrentLevel < 0)
        {
            CurrentLevel = 0;//cant go any further back
        }
        
        SceneManager.LoadScene(levels[CurrentLevel]);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
    }

    public void StartNewGame()
    {
        CurrentLevel = 1;//0;
        SceneManager.LoadScene(levels[1]);
    }

   
}

