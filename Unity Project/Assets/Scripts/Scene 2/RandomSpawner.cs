using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    void Update ()
     {
        if (Input.GetMouseButtonDown(0))
        {
            // creating a random position
            Vector3 randomposition = new Vector3(Random.Range(-8, 9), 5, Random.Range(-8, 9));
            Instantiate(cubePrefab, randomposition, Quaternion.identity);
        }
    }
    
}
