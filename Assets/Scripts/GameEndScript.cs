using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEndScript : MonoBehaviour
{

    public GameObject gameOver;
    public static bool gameOverTrigger = false;

    void Start(){
        gameOver.gameObject.SetActive(false);
    }



    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            gameOver.gameObject.SetActive(true);
            gameOverTrigger = true;
            Time.timeScale = 0;
        }
    }
}
