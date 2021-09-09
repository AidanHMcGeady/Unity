using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 25;

    public GameObject[] projectile;
    public int ProjectileIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if(transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
            Throw();
    }

    void Throw()
    {
        ProjectileIndex = Random.Range(0, projectile.Length);

        Instantiate(projectile[ProjectileIndex], transform.position, projectile[ProjectileIndex].transform.rotation);
    }


}
