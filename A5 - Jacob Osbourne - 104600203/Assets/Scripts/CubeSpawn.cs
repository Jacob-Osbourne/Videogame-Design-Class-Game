using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject redCube;
    public GameObject greenCube;
    public GameObject blueCube;
    public GameObject goldCube;
    public float spawn = 0;
    public float time = 0;
    public float speed = 1f;
    
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        time += (Time.deltaTime);
        if (time > 10f)
        {
            speed++;
            time -= 10f;
        }
        spawn += (Time.deltaTime) * speed;
        if (spawn > 1)
        {
            int randomSpawn = Random.Range(0, 6);
            int randomCube = Random.Range(0, 10);

            switch (randomSpawn)
            {
                //top
                case 0:
                    spawn -= 1f;
                    switch (randomCube)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            Instantiate(blueCube, new Vector3(-6, -13, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 4:
                        case 5:
                        case 6:
                            Instantiate(redCube, new Vector3(-6, -5, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 7:
                        case 8:
                            Instantiate(greenCube, new Vector3(-12, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 9:
                            Instantiate(goldCube, new Vector3(-6, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                    }

                    break;
                //bot
                case 1:
                    spawn -= 1f;
                    switch (randomCube)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            Instantiate(blueCube, new Vector3(-3, -13, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 4:
                        case 5:
                        case 6:
                            Instantiate(redCube, new Vector3(-3, -5, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 7:
                        case 8:
                            Instantiate(greenCube, new Vector3(-10, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 9:
                            Instantiate(goldCube, new Vector3(-3, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                    }

                    break;
                //right
                case 2:
                    spawn -= 1f;
                    switch (randomCube)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            Instantiate(blueCube, new Vector3(-1, -13, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 4:
                        case 5:
                        case 6:
                            Instantiate(redCube, new Vector3(-1, -5, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 7:
                        case 8:
                            Instantiate(greenCube, new Vector3(-7, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 9:
                            Instantiate(goldCube, new Vector3(-1, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                    }

                    break;
                //left
                case 3:
                    spawn -= 1f;
                    switch (randomCube)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            Instantiate(blueCube, new Vector3(1, -13, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 4:
                        case 5:
                        case 6:
                            Instantiate(redCube, new Vector3(1, -5, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 7:
                        case 8:
                            Instantiate(greenCube, new Vector3(-5, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 9:
                            Instantiate(goldCube, new Vector3(1, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                    }

                    break;
                case 4:
                    spawn -= 1f;
                    switch (randomCube)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            Instantiate(blueCube, new Vector3(3, -13, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 4:
                        case 5:
                        case 6:
                            Instantiate(redCube, new Vector3(3, -5, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 7:
                        case 8:
                            Instantiate(greenCube, new Vector3(-3, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 9:
                            Instantiate(goldCube, new Vector3(3, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                    }
                    break;
                case 5:
                    spawn -= 1f;
                    switch (randomCube)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            Instantiate(blueCube, new Vector3(6, -13, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 4:
                        case 5:
                        case 6:
                            Instantiate(redCube, new Vector3(6, -5, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 7:
                        case 8:
                            Instantiate(greenCube, new Vector3(0, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                        case 9:
                            Instantiate(goldCube, new Vector3(6, -6, 0), new Quaternion(0f, 0f, 0f, 0f));
                            break;
                    }
                    break;
            }
        }
    }
}
