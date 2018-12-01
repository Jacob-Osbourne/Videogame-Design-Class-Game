using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliceGameControl : MonoBehaviour {

    GameObject poof = null;
    public Text cubeScore;
    public Text cubeHighscore;
    public int cubeScoreGame = 0;
	// Use this for initialization
	void Start () {
        cubeScore.text = "Score: 0";
        cubeHighscore.text = "Highscore: 0";
    }

    Ray GenerateMouseRay(Vector3 touchPos)
    {
        Vector3 mousePosFar = new Vector3(touchPos.x, touchPos.y, Camera.main.farClipPlane);
        Vector3 mousePosNear = new Vector3(touchPos.x, touchPos.y, Camera.main.nearClipPlane);

        Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosFar);
        Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);

        Ray mr = new Ray(mousePosN, mousePosF - mousePosN);
        return mr;
    }
	// Update is called once per frame
	void Update () {
        if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0)))
        {
            Plane objPlane = new Plane(Camera.main.transform.forward * -1, this.transform.position);
            Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            if (objPlane.Raycast(mRay, out rayDistance))
            {
                this.transform.position = mRay.GetPoint(rayDistance);
            }

            Ray mouseRay = GenerateMouseRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(mouseRay.origin, mouseRay.direction, out hit))
            {
                poof = hit.transform.gameObject;
                if (poof.transform.parent.gameObject.tag == "BlueCube")
                {
                    cubeScoreGame += 5;
                }
                else if (poof.transform.parent.gameObject.tag == "RedCube")
                {
                    cubeScoreGame += 10;
                }
                else if (poof.transform.parent.gameObject.tag == "GreenCube")
                {
                    cubeScoreGame += 15;
                }
                else if (poof.transform.parent.gameObject.tag == "GoldCube")
                {
                    cubeScoreGame += 25;
                }

                cubeScore.text = "Score: " + cubeScoreGame;
                int cubeHighscoreGame = PlayerPrefs.GetInt("CNHighscore");
                if (cubeScoreGame > cubeHighscoreGame)
                {
                    PlayerPrefs.SetInt("CNHighscore", cubeScoreGame);
                }
                cubeHighscore.text = "Highscore: " + PlayerPrefs.GetInt("CNHighscore");

                Rigidbody[] cubeArray = poof.transform.parent.gameObject.GetComponentsInChildren<Rigidbody>();
                
                for(int i = 1; i < cubeArray.Length; i++)
                {
                    cubeArray[i].isKinematic = false;
                    cubeArray[i].useGravity = true;
                }
                Destroy(poof);
            }
        }
	}
}
