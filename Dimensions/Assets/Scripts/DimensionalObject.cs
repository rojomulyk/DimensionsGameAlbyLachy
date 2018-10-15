using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Dimensions
{
    Normal,
    Purple,
    Yellow,
    Red,
    Green,
    Black
}

public class DimensionalObject : MonoBehaviour {


    public Dimensions MyDimension;
    public Player Player;

    public new Collider collider;
    public new Renderer renderer;

	void Start()
	{
        Player = GameObject.Find("Player").GetComponent<Player>();
	}

	void Update () 
    {
        if(Player.CurrentDimension == MyDimension)
        {
            collider.enabled = true;
            renderer.enabled = true;
        }
        else
        {
            collider.enabled = false;
            renderer.enabled = false;
        }
	}
}
