using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelZone : MonoBehaviour {

    public Rigidbody Player;

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject == Player)
        {
            Debug.Log("hi");
        }

    }

}
