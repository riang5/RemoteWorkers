using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
     //   Instantiate(Ball, transform.position, transform.rotation);
        InvokeRepeating("SpawnBall", 0f, 1f);
    }

    void SpawnBall()
    {
        Instantiate(Ball, new Vector3(Random.Range(-5f, 5f), transform.position.y, transform.position.z), transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
