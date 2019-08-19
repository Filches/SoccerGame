using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed;
    public float clampValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle(Input.GetAxis("Horizontal"));
        Debug.Log(Input.GetAxis("Horizontal"));
    }

    public void MovePaddle(float amountToMove)
    {
        Vector3 clampedGameObjectPosition =
            gameObject.transform.position + new Vector3(0, 0, amountToMove * speed);
        clampedGameObjectPosition.z = Mathf.Clamp(clampedGameObjectPosition.z, -clampValue, clampValue);

        gameObject.transform.position = clampedGameObjectPosition;
    }

}
