using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public void RestartLevel(){
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("The button is working");
        ScoreManager.scoreCount = 0;
    }

    public void NextLevel(){
        
    }
}
