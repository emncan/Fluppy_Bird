using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public GameObject bird;
    private Text text;
    private int score;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bird != null)
        {
            score = bird.GetComponent<PlayerMove>().score;
        }
        text.text = "" + score;
    }
}
