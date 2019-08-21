using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private int player1Score = 0;
    private int player2Score = 0;
    public TextMesh text;

    private void Start()
    {
        text = GetComponent<TextMesh>();
    }

    public void Team1Scored()
    {
        player1Score++;
        text.text = player1Score.ToString() + " : " + player2Score.ToString();
    }

    public void Team2Scored()
    {
        player2Score++;
        text.text = player1Score.ToString() + " : " + player2Score.ToString();
    }

}
