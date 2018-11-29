using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IChooseYellow : MonoBehaviour {

    public GameObject painter;

    public void OnMouseDown()
    {
        painter.GetComponent<Painting>().colour = 2; 
    }
}
