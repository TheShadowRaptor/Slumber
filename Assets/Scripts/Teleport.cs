using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [Header("Teleport Destination")]
    public GameObject dest;

    [Header("Player GameObject")]
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Teleport");
            player.transform.position = dest.transform.position;
        }
    }
}
