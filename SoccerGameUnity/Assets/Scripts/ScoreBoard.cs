using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public int team1;
    public int team2;

    public void Team1Scored()
    {
        team1 += 1;
    }

    public void Team2Scored()
    {
        team2++;
    }

}
