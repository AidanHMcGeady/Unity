using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PROJECTILE : MonoBehaviour
{
    public float speed = 10f;
    public float TopBoundary = 30;
    public float lowerBoundary = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z > TopBoundary)
            Destroy(gameObject);

        if (transform.position.z < lowerBoundary)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
