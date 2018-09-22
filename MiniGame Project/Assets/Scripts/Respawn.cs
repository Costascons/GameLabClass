using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Found script on how to respawn character in game here: https://www.youtube.com/watch?v=nBgCeJBMT0k
public class Respawn : MonoBehaviour {
    //SerializedField for two private variables that won't be public but
    //are still needed to be seen in the Inspector window
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
    }

}
