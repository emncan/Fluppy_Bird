using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoDe : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject UI = GameObject.FindGameObjectWithTag("UserInterface");
            UI.GetComponent<UIController>().GameOver();
            UI.GetComponent<UIController>().hitSound();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            other.GetComponent<PlayerMove>().Score();
        }
    }
}
