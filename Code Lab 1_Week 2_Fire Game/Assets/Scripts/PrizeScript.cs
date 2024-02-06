using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PrizeScript : MonoBehaviour
{
    //The prize relocates to a random place on collection
    void OnCollisionEnter2D(Collision2D col)
    {
        //score goes up by 1
        // name of the class then what that static variable is then whatever variable you need from it
        GameManager.instance.score++;

        //prize relocates to random new location
        transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5));

    }
}

