using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPad : MonoBehaviour {

    public Dimensions dimension;

    public Material On;
    public Material Off;

    public AudioSource Source;
    public AudioClip ClipOn;
    public AudioClip ClipOff;
    public Rigidbody Target;
    public bool Activate;

    public Player Player;

    public Collider Base;

    bool Pressed;

	void Start () {
        Player = GameObject.Find("Player").GetComponent<Player>();
	}
	
	
	void Update () {

        if (Player.CurrentDimension == dimension)
        {
            if (Pressed == true)
            {
                gameObject.GetComponent<Renderer>().material = On;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material = Off;
            }
        }
        else
        {
            gameObject.GetComponent<Renderer>().material = Off;
        }
	}

	private void OnTriggerEnter(Collider other)
	{
        if(other != Base)
        {
            if (Player.CurrentDimension == dimension)
            {
                Pressed = true;
                Source.clip = ClipOn;
                Source.Play();
                Activate = true;
            }
        }
	}

    private void OnTriggerExit(Collider other)
    {
        if (other != Base)
        {
            Pressed = false;
            Source.clip = ClipOff;
            Source.Play();
            Activate = false;
        }
    }

}
