using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BubbleSpawn : MonoBehaviour
{

    public GameObject go; 
    private float _interval = 1f; 
    private float _elapsedTime = 0f;
    public int bubbleDeathCounter = 0;
    public int popped = 0;
    public Text score;
    public Text death;
    public int pleb;

    void start()
    {
        PlayerPrefs.SetInt("Popped", 0);
    }
    void Update()
    {
        
        _elapsedTime += Time.deltaTime; 
        if (_elapsedTime > _interval) 
        {
            int randomSpawnSide = Random.Range(0, 4);

            switch (randomSpawnSide)
            {
                //top
                case 0:
                    _elapsedTime -= 1f; 
                    Instantiate(go, new Vector3(Random.Range(-6f, 6f), 6, 0), new Quaternion(0f, 0f, 0f, 0f));
                    break;
                //bot
                case 1:
                    _elapsedTime -= 1f; 
                    Instantiate(go, new Vector3(Random.Range(-6f, 6f), -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                    break;
                //right
                case 2:
                    _elapsedTime -= 1f; 
                    Instantiate(go, new Vector3(8, Random.Range(-4f, 4f), 0), new Quaternion(0f, 0f, 0f, 0f));
                    break;
                //left
                case 3:
                    _elapsedTime -= 1f; 
                    Instantiate(go, new Vector3(-8, Random.Range(-4f, 4f), 0), new Quaternion(0f, 0f, 0f, 0f));
                    break;
            }
        }
    }

    void LateUpdate()
    {
        pleb = PlayerPrefs.GetInt("Popped");
        if (bubbleDeathCounter >= 10)
        {

            int BuBhighscore = PlayerPrefs.GetInt("BubHighscore");
            if (popped > BuBhighscore)
            {
                PlayerPrefs.SetInt("BubHighscore", popped);
            }
            

            SceneManager.LoadScene("AfterBubble");

        }

        PlayerPrefs.SetInt("Popped", popped);
        score.text = "Score: " + popped;
        death.text = "Bubbles Timed Out: " + bubbleDeathCounter;
    }

}
