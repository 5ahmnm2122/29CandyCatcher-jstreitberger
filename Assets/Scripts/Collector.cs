using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] int score;

    private void Start()
    {
        scoreText.text = "0";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "candy")
        {
            score = score + 1;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }

        if(other.tag == "bomb")
        {
            score = score - 1;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }
    }

}

