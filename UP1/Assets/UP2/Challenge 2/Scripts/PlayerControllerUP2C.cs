using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerUP2C : MonoBehaviour
{
    public GameObject dogPrefab;
    public static bool DogOut = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && DogOut == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            DogOut = false;
        }
    }
}
