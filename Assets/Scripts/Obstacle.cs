using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // TODO: A public float variable to control how fast the obstacle moves across the screen
    public float moveSpeed = 4.0f;
    // TODO: A public float variable to control how far the object should go before being destroyed offscreen.
    public float travelDistance = -10.75f;

    void Start()
    {

    }

    void Update()
    {
        // TODO: Move the obstacle to the left at a constant rate. 
        // Make sure this calculation is frame rate independent (hint: use Time.deltaTime)
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        // TODO: If the obstalce is off screen to the left, destroy this GameObject (hint: Destroy(gameObject))
        if (transform.position.x <= travelDistance)
        {
            Destroy(gameObject);
        } 
    }
}
