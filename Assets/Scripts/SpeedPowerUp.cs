using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : Paddle
{
    public float increase = 5.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            GameObject playerPaddle = collision.gameObject;
            PlayerPaddle playerScript = playerPaddle.GetComponent<PlayerPaddle>();

            if (playerScript)
            {
                playerScript.speed += increase;

                

               
                Destroy(gameObject);
            }
        }
    }
}
