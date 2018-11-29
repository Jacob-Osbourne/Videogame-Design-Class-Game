using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

    public void buttonHighscores()
    {
        SceneManager.LoadScene("Highscore");
    }
    public void buttonBubblePopper()
    {
        SceneManager.LoadScene("BubblePopper");
    }
    public void buttonPainting()
    {
        SceneManager.LoadScene("Painting");
    }
    public void buttonCubeNinja()
    {
        SceneManager.LoadScene("CubeNinja");
    }
    public void buttonMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void buttonExitGame()
    {
        Application.Quit();
    }
}
