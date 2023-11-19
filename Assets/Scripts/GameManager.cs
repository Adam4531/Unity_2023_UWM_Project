using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;

    void Start()
    {
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameEndScript.gameOverTrigger == true){
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void OnClickButton(){
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
