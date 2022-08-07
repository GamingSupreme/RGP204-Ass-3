using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    //public Text highscoreText;

    int score = 0;
    //int highscore = 0;
    public static int totalScore;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
        scoreText.text = string.Format("Score : {00} ", score);
        //highscoreText.text = highscore.ToString();
    }

    private void Update()
    {
        totalScore = score;
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString();
        Debug.Log(score);
    }
}
