using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerController
{
    player1,
    player2
}

public class PaddleMovement : MonoBehaviour
{
    public PlayerController playerSetting;
    public float speed;
    public float clampValue;
    public string axisName;

    private void Start()
    {
        if(playerSetting == PlayerController.player1)
        {
            axisName = "player1";
        }
        if(playerSetting == PlayerController.player2)
        {
            axisName = "player2";
        }
    }

    void update()
    {
        MovePaddle(Input.GetAxis(axisName));
    }

    public void MovePaddle(float amountToMove)
    {
        Vector3 clampedGameObjectPosition =
            gameObject.transform.position + new Vector3(0, 0, amountToMove * speed);
        clampedGameObjectPosition.z = Mathf.Clamp(clampedGameObjectPosition.z, -clampValue, clampValue);

        gameObject.transform.position = clampedGameObjectPosition;
    }

}
