/* 
 * Anthony Wessel
 * Assignment 3 Prototype 2
 * initializes the food prefab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject prefabToShoot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, Quaternion.identity);
        }
    }
}
