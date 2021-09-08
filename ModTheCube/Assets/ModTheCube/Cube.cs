using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float xAngle, yAngle, zAngle;

    private GameObject cube1, cube2;

    public Vector3 scaleChange1;
    public Vector3 scaleChange2;

    public int Num;

    Color color1 = Color.red;
    Color color2 = Color.green;
    
    void Awake()
    {
        cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(10f, 0.0f, 0.0f);
        cube1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        cube1.GetComponent<Renderer>().material.color = color1;
        cube1.name = "Self";

        cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = new Vector3(-10f, 0.0f, 0.0f);
        cube2.transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
        cube2.GetComponent<Renderer>().material.color = color2;
        cube2.name = "World";

        InvokeRepeating("RotateCubes", 1f, Random.Range(0.01f, 0.25f));
        InvokeRepeating("ChangeColor", 1f, 1f);
        InvokeRepeating("ScaleCube", 1f, 1f);
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
        Num = Random.Range(0, 5);

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

        cube1.GetComponent<Renderer>().material.color = color1;
        cube2.GetComponent<Renderer>().material.color = color2;
    }

    void ScaleCube()
    {
        scaleChange1 = new Vector3(Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10));
        scaleChange2 = new Vector3(Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10));

        cube1.transform.localScale = scaleChange1;
        cube2.transform.localScale = scaleChange2;
    }
}
