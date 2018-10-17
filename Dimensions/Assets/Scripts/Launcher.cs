using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {

    public float LauncherForce;
    public GameObject Players;
    public Rigidbody Playerrb;

    private void Start()
    {
        Playerrb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Playerrb.AddForce(0, 60, 10 * Time.deltaTime);
    }

}
