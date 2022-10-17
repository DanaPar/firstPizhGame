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


        if (score >= 100)
        {
            SceneManager.LoadScene("Finish");
            
        }

        if (score >= 50)
        {
            Vector2 start = racoon.transform.position;
            Vector2 destination = new Vector2(5, -0.52f);
            racoon.transform.position = Vector2.Lerp(start, destination, Time.deltaTime * 1);
        }

    }

    
}
