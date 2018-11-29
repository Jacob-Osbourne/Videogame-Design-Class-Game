using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour {

    public float time = 0;
    GameObject bub;
    public GameObject control;
    public int form = 0;
    

    // Use this for initialization
    void Start () {
		bub = this.gameObject;
        control = GameObject.Find("BubbleController");
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if (time >= 10)
        {
           
            control.GetComponent<BubbleSpawn>().bubbleDeathCounter++;
            Destroy(bub);
        }
	}

    public void OnMouseDown()
    {
        control.GetComponent<BubbleSpawn>().popped++;
        Destroy(bub);
    }

    void FixedUpdate()
    {

        if (this.transform.position.y > 5)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);
            this.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-0.1f, 0.1f), -0.1f, 0), ForceMode.Impulse);
        } else if (this.transform.position.y < -5)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);
            this.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-0.1f, 0.1f), 0.1f, 0), ForceMode.Impulse);
        }
        else if (this.transform.position.x > 7)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);
            this.GetComponent<Rigidbody>().AddForce(new Vector3(-0.1f, Random.Range(-0.1f, 0.1f), 0), ForceMode.Impulse);
        }
        else if (this.transform.position.x < -7)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0.1f, Random.Range(-0.1f, 0.1f), 0), ForceMode.Impulse);
        }
    }
}
