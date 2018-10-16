using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelZone : MonoBehaviour {

    public GameObject Player;
    public Player player;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == Player)
        {
            player.Canswitch = false;
            player.CancelNoise();
        }
       
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject == Player)
        {
            player.Canswitch = true;
        }
    }

}
