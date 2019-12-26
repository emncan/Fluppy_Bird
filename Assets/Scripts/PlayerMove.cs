using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    public float antiGravityForce = 250;
    public AudioSource audioData;
    public int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        for(var i=0; i< Input.touchCount; i++ )
        {
            if(Input.GetTouch(i).phase == TouchPhase.Began)
            {
                rb.AddForce(Vector3.up * antiGravityForce);
                audioData.Play(0);
            }
        }
    }

    public void Score()
    {
        score += 1;
        GetComponents<AudioSource>()[0].Play();
    }
}
