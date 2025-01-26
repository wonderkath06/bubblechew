using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MsinMenu : MonoBehaviour
{
    private bool gameStarted = false;

    void Update()
    {
        if (!gameStarted && Input.anyKeyDown) ;
        {
            gameStarted = true;
            StartGame();
        }
    }

    void StartGame()
    {
        SceneManager.LoadScene(2);
    }

}
