using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text time;
    public float timeFloat = 60;

    void Start()
    {
        StartCoroutine(timer());    
    }

    private void TimeCallculation()
    {
        timeFloat = timeFloat - 1;

    }

    IEnumerator timer()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            TimeCallculation();
        }
    }
    void Update()
    {
        time.text = timeFloat.ToString() + "s";

        if (timeFloat <= 0)
        {
            SceneManager.LoadScene("EndScene");   
        }
    }
}

