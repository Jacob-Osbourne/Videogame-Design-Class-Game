using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetBubScore : MonoBehaviour {

    public Text score;
    public Text highscore;
    public int scoreInt;
    public int hsInt;

    // Use this for initialization
    void Start () {
        scoreInt = PlayerPrefs.GetInt("Popped");
        hsInt = PlayerPrefs.GetInt("BubHighscore");
        score.text = "Score: " + scoreInt;
        highscore.text = "Highscore: " + hsInt;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
