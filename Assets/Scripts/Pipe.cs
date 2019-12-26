using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 2;

    void Update()
    {
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);
        }
    }
}
