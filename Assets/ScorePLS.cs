using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePLS : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = ScoreManager.totalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
         scoreText.text = ScoreManager.totalScore.ToString(); 
    }
}
