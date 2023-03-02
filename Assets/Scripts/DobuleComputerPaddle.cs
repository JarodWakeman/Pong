using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobuleComputerPaddle : MonoBehaviour
{
    public GameObject computerPaddle;
    public GameObject computerPadddleSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gameObj;
        gameObj = GameObject.Instantiate(computerPaddle, computerPadddleSpawn.transform.position, computerPadddleSpawn.transform.rotation);
        gameObj.transform.position = (new Vector3(11, 0, 0));

        Destroy(gameObject);
    }
}
