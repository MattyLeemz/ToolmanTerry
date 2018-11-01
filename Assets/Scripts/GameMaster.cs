using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    public static GameMaster gm;

    void Start()
    {
     if(gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("spawn").GetComponent<GameMaster>();
        }  
    }
    public Transform player;
    public Transform spawnPoint;

    public void RespawnPlayer()
    {
        Instantiate(player, spawnPoint.position, spawnPoint.rotation);
    }
    public static void KillPlayer(Player player)
    {
        Destroy(player.gameObject);
        
    }
}
