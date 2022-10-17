using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class Score : MonoBehaviour
{

    int score;
    Text scoreText;

    float timer;
    float maxTime;

    public GameObject racoon;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        maxTime = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            score++;
            scoreText.text = score.ToString("00000");
            timer = 0;
        }


        if (score >= 400)
        {
            SceneManager.LoadScene("Finish");
            
        }

        if (score >= 50 && score <= 100)
        {
            Vector2 start = racoon.transform.position;
            Vector2 destination = new Vector2(6, -0.52f);
            racoon.transform.position = Vector2.Lerp(start, destination, Time.deltaTime * 1);
        }

        if (score >= 100 && score <= 150)
        {
            Vector2 start = racoon.transform.position;
            Vector2 destination = new Vector2(5, -0.52f);
            racoon.transform.position = Vector2.Lerp(start, destination, Time.deltaTime * 1);
        }

        if (score >= 150 && score <= 200)
        {
            Vector2 start = racoon.transform.position;
            Vector2 destination = new Vector2(4, -0.52f);
            racoon.transform.position = Vector2.Lerp(start, destination, Time.deltaTime * 1);
        }

        if (score >= 200 && score <= 250)
        {
            Vector2 start = racoon.transform.position;
            Vector2 destination = new Vector2(3, -0.52f);
            racoon.transform.position = Vector2.Lerp(start, destination, Time.deltaTime * 1);
        }

        if (score >= 250 && score <= 350)
        {
            Vector2 start = racoon.transform.position;
            Vector2 destination = new Vector2(2, -0.52f);
            racoon.transform.position = Vector2.Lerp(start, destination, Time.deltaTime * 1);
        }

        if (score >= 350)
        {
            Vector2 start = racoon.transform.position;
            Vector2 destination = new Vector2(20, -0.52f);
            racoon.transform.position = Vector2.Lerp(start, destination, Time.deltaTime * 1);
        }



    }

    
}
