using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float xAngle, yAngle, zAngle;

    private GameObject cube1, cube2;
    
    static Color color1 = Color.red;
    Color color2 = Color.green;

    void Awake()
    {
        cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(10f, 0.0f, 0.0f);
        cube1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        cube1.GetComponent<Renderer>().material.color = Color.red;
        cube1.name = "Self";

        cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = new Vector3(-10f, 0.0f, 0.0f);
        cube2.transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
        cube2.GetComponent<Renderer>().material.color = Color.green;
        cube2.name = "World";

        InvokeRepeating("RotateCubes", 1f, 0.05f);
        InvokeRepeating("ChangeColor", 1f, 1f);
    }

    void Update()
    {

    }

    void RotateCubes()
    {
        xAngle = Random.Range(0, 15);
        yAngle = Random.Range(0, 15);
        zAngle = Random.Range(0, 15);

        cube1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        cube2.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    }

    void ChangeColor()
    {
        int Num = Random.Range(0, 5);

        if(Num == 0)
        {
            color1 = Color.blue;
            color2 = Color.yellow;
        }
        else if (Num == 1)
        {
            color1 = Color.red;
            color2 = Color.black;
        }
        else if (Num == 2)
        {
            color1 = Color.yellow;
            color2 = Color.red;
        }
        else if (Num == 3)
        {
            color1 = Color.white;
            color2 = Color.blue;
        }
        else if (Num == 4)
        {
            color1 = Color.black;
            color2 = Color.white;
        }
        else
        {
            color1 = Color.green;
            color2 = Color.blue;
        }
    }
}
