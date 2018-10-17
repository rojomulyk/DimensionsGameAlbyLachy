using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {

    public float LauncherForce;
    public GameObject Players;
    public Rigidbody Playerrb;

    private void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        Playerrb.AddForce(LauncherForce, LauncherForce + 250, 0 * Time.deltaTime);
    }

}
