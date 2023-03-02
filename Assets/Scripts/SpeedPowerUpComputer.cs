using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUpComputer : Paddle
{
    public float increase = 5.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            GameObject computerPaddle = collision.gameObject;
            Player2Paddle playerScript = computerPaddle.GetComponent<Player2Paddle>();

            if (playerScript)
            {
                playerScript.speed += increase; 
                Destroy(gameObject);
            }
        }
    }
}
