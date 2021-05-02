using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string levelBaseText;
    public TextMeshProUGUI centerMessage;
    public float messageDisplayTime;
    
    void Start()
    {
        // call the display new level function
        centerMessage.text = DisplayLevelMessage(levelBaseText);
        
        // clear the message after a brief time
        Invoke("ClearText", messageDisplayTime);
    }
    
    
    // write a function that will display the current level
    private string DisplayLevelMessage(string message)
    {
        // get the level number 
        string levelNumber = (SceneManager.GetActiveScene().buildIndex + 1).ToString();
        
        string levelText = levelBaseText + levelNumber;
        return levelText;
    }
    
    // write a function that will clear the center message text
    private void ClearText()
    {
        centerMessage.text = String.Empty;
    }
}
