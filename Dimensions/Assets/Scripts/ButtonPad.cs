using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPad : MonoBehaviour {

    public Material On;
    public Material Off;

    public AudioSource Source;
    public AudioClip ClipOn;
    public AudioClip ClipOff;

    public Collider Base;

    bool Pressed;

	void Start () {
		
	}
	
	
	void Update () {

        if(Pressed == true)
        {
            gameObject.GetComponent<Renderer>().material = On;
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
            Pressed = true;
            Source.clip = ClipOn;
            Source.Play();
        }
	}

    private void OnTriggerExit(Collider other)
    {
        if (other != Base)
        {
            Pressed = false;
            Source.clip = ClipOff;
            Source.Play();
        }
    }

}
