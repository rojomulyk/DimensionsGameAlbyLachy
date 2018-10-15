using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class Player : MonoBehaviour {

    public Dimensions CurrentDimension;

    public PostProcessingProfile Normal;
    public PostProcessingProfile Red;
    public PostProcessingProfile Green;
    public PostProcessingProfile Yellow;
    public PostProcessingProfile Black;
    public PostProcessingProfile Purple;

    PostProcessingBehaviour Me;


	// Use this for initialization
	void Start () {
        Me = gameObject.GetComponent<PlayerMotor>().cam.GetComponent<PostProcessingBehaviour>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrentDimension = Dimensions.Purple;
            Me.profile = Purple;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrentDimension = Dimensions.Red;
            Me.profile = Red;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CurrentDimension = Dimensions.Green;
            Me.profile = Green;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CurrentDimension = Dimensions.Yellow;
            Me.profile = Yellow;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            CurrentDimension = Dimensions.Black;
            Me.profile = Black;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            CurrentDimension = Dimensions.Normal;
            Me.profile = Normal;
        }
	}
}
