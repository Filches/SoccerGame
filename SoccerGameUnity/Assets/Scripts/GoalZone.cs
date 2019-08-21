using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalZone : MonoBehaviour
{
    public string teamname;
    public ScoreBoard sm;

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        BallManager.instance.InstantiateBall();

        if(teamname == "team1")
        {
            sm.Team1Scored();
        }

        if (teamname == "team2")
        {
            sm.Team2Scored();
        }
    }
}