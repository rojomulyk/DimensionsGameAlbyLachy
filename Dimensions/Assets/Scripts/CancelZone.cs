using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelZone : MonoBehaviour {

    public GameObject Player;
    public Player player;

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject == Player)
        {
            player.Canswitch = false;
        }
       
    }

    void OnTriggerExit(Collider coll)
    {
        player.Canswitch = true;
    }

}
