using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public GameObject Freezer;
    public Player Player;
    private float range = 100;

    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(Freezer.transform.position, Freezer.transform.forward, out Hit, range))
        {
            Player.health = Player.health - 10;           
        }
    }

}
