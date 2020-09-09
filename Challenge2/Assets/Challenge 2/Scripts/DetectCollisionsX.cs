using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dog"))
        {
            DisplayScore.score++;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
    }
}
