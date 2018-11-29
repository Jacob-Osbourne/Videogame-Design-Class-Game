using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHighscore : MonoBehaviour {

    public Text BubbleHighscore;
    public Text PaintingHighscore;
    public Text CNHighscore;
    public int CNHighscoreInt;
    public int PaintingHighscoreInt;
    public int BubbleHighscoreInt;

    // Use this for initialization
    void Start () {
        BubbleHighscoreInt = PlayerPrefs.GetInt("BubHighscore");
        CNHighscoreInt = PlayerPrefs.GetInt("CNHighscore");
        PaintingHighscoreInt = PlayerPrefs.GetInt("PaintingHighscore");
        BubbleHighscore.text = "Bubble Popper: " + BubbleHighscoreInt;
        PaintingHighscore.text = "Painting: " + PaintingHighscoreInt;
        CNHighscore.text = "Cube Ninja: " + CNHighscoreInt;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
