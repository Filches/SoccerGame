using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public static BallManager instance;
    private List<int> potentialAngles = new List<int> { 60,-60, 240, -240 };

    public GameObject ball;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        InstantiateBall();
    }


    public void InstantiateBall()
    {
        int index = Random.Range(0, 4);
        GameObject ballCopy = Instantiate(ball, transform.position, Quaternion.Euler(0, potentialAngles[index], 0));
    }


}
