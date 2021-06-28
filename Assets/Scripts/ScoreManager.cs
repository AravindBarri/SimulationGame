using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score = 100;
    Text ScoreText;
    // Start is called before the first frame update
    private void Start()
    {
        ScoreText = this.GetComponent<Text>();
        ScoreText.text = "SCORE : " + Score;
    }
    public void decreaseScore()
    {
        Score -= 1;
        ScoreText.text = "SCORE : " + Score;
    }
}
