using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCube : MonoBehaviour {

    public bool go = true;
    public int Value = 15;
    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        if (go)
        {
            go = false;
            if (this.transform.position.x < -5)
            {
                this.transform.position = new Vector3(this.transform.position.x, -6, 0);
                this.GetComponent<Rigidbody>().AddForce(new Vector3(2f, 13f, 0), ForceMode.Impulse);
            }
            else if (this.transform.position.x > -5 && this.transform.position.x < -2)
            {
                this.transform.position = new Vector3(this.transform.position.x, -6, 0);
                this.GetComponent<Rigidbody>().AddForce(new Vector3(2f, 13f, 0), ForceMode.Impulse);
            }
            else if (this.transform.position.x > -2 && this.transform.position.x < 0)
            {
                this.transform.position = new Vector3(this.transform.position.x, -6, 0);
                this.GetComponent<Rigidbody>().AddForce(new Vector3(2f, 13f, 0), ForceMode.Impulse);
            }
            else if (this.transform.position.x > 0 && this.transform.position.x < 2)
            {
                this.transform.position = new Vector3(this.transform.position.x, -6, 0);
                this.GetComponent<Rigidbody>().AddForce(new Vector3(-2f, 13f, 0), ForceMode.Impulse);
            }
            else if (this.transform.position.x > 2 && this.transform.position.x < 4)
            {
                this.transform.position = new Vector3(this.transform.position.x, -6, 0);
                this.GetComponent<Rigidbody>().AddForce(new Vector3(-2f, 13f, 0), ForceMode.Impulse);
            }
            else if (this.transform.position.x > 5)
            {
                this.transform.position = new Vector3(this.transform.position.x, -6, 0);
                this.GetComponent<Rigidbody>().AddForce(new Vector3(-2f, 13f, 0), ForceMode.Impulse);
            }
        }
        if (this.transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }
    }
}
