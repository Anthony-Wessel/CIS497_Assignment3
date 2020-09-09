/* 
 * Anthony Wessel
 * Assignment 3 Prototype 2
 * Detects collision between food and animals and increments score
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
