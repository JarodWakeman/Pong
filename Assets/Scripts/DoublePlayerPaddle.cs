using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePlayerPaddle : MonoBehaviour
{
    public GameObject playerPaddle;
    public GameObject padddleSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gameObj;
        gameObj = GameObject.Instantiate(playerPaddle, padddleSpawn.transform.position, padddleSpawn.transform.rotation);
        gameObj.transform.position = (new Vector3 (-11, 0, 0));

        Destroy(gameObject);
    }
}
