using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Painting : MonoBehaviour {


    //Colours Red = 1, Yellow = 2, Blue = 3, Green = 4
    public int colour = 1;
    public LayerMask maskPaint = -1;
    public LayerMask maskDelete = -1;
    public GameObject redPaint;
    public GameObject yellowPaint;
    public GameObject bluePaint;
    public GameObject greenPaint;
    public int point;

    void start()
    {
        point = 0;
    }

    public void buttonMenu()
    {
        if (point > PlayerPrefs.GetInt("PaintingHighscore"))
        {
            PlayerPrefs.SetInt("PaintingHighscore", point);
        }

        SceneManager.LoadScene("Menu");
    }


    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetMouseButton(0))
        {
            if (colour == 1)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))// float.PositiveInfinity, maskPaint.value))
                {            
                    if (hit.collider.gameObject.tag != "MainPaint")
                    {
                        point++;
                        Instantiate(redPaint, new Vector3(hit.point.x, hit.point.y, 0), new Quaternion(0f, 0f, 0f, 0f));
                    }
                }
            }
            else if (colour == 2)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))// float.PositiveInfinity, maskPaint.value))
                {
                    if (hit.collider.gameObject.tag != "MainPaint")
                    {
                        point++;
                        Instantiate(yellowPaint, new Vector3(hit.point.x, hit.point.y, 0), new Quaternion(0f, 0f, 0f, 0f));
                    }
                }
            }
            else if (colour == 3)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))// float.PositiveInfinity, maskPaint.value))
                {
                    if (hit.collider.gameObject.tag != "MainPaint")
                    {
                        point++;
                        Instantiate(bluePaint, new Vector3(hit.point.x, hit.point.y, 0), new Quaternion(0f, 0f, 0f, 0f));
                    }
                }
            }
            else if (colour == 4)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))// float.PositiveInfinity, maskPaint.value))
                {
                    if (hit.collider.gameObject.tag != "MainPaint")
                    {
                        point++;
                        Instantiate(greenPaint, new Vector3(hit.point.x, hit.point.y, 0), new Quaternion(0f, 0f, 0f, 0f));
                    }
                }
            }
        }
        else if (Input.GetMouseButton(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, float.PositiveInfinity, maskDelete.value))
            {
                
                if (hit.collider.gameObject.tag != "MainPaint")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
        
    }
}
