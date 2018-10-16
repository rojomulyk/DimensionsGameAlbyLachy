using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class Player : MonoBehaviour {

    public Dimensions CurrentDimension;

    public AudioClip DimensionChange;
    public GameObject DimensionSound;

    public PostProcessingProfile Normal;
    public PostProcessingProfile Red;
    public PostProcessingProfile Green;
    public PostProcessingProfile Yellow;
    public PostProcessingProfile Black;
    public PostProcessingProfile Purple;
    public bool Canswitch;
    private bool Changing;

    

    PostProcessingBehaviour Me;


	// Use this for initialization
	void Start () {
        Me = gameObject.GetComponent<PlayerMotor>().cam.GetComponent<PostProcessingBehaviour>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Canswitch)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Exclaim))
            {
               CurrentDimension = Dimensions.Purple;
                Me.profile = Purple;
                AudioSource.PlayClipAtPoint(DimensionChange, transform.position);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.At))
            {
                CurrentDimension = Dimensions.Red;
                Me.profile = Red;
                AudioSource.PlayClipAtPoint(DimensionChange, transform.position);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Hash))
            {
                CurrentDimension = Dimensions.Green;
               Me.profile = Green;
                AudioSource.PlayClipAtPoint(DimensionChange, transform.position);
             }
              if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Dollar))
              {
                  CurrentDimension = Dimensions.Yellow;
                  Me.profile = Yellow;
                 AudioSource.PlayClipAtPoint(DimensionChange, transform.position);
             }
             if (Input.GetKeyDown(KeyCode.Alpha5))
              {
                  CurrentDimension = Dimensions.Black;
                  Me.profile = Black;
                  AudioSource.PlayClipAtPoint(DimensionChange, transform.position);
               }
               if (Input.GetKeyDown(KeyCode.Tab))
               {
                 CurrentDimension = Dimensions.Normal;
                  Me.profile = Normal;
                  AudioSource.PlayClipAtPoint(DimensionChange, transform.position);
              }
        }

        if (Canswitch == false)
        {
            CurrentDimension = Dimensions.Normal;
            Me.profile = Normal;
        }

        if (Changing)
        {
            CurrentDimension = Dimensions.Normal;
            Me.profile = Normal;
            AudioSource.PlayClipAtPoint(DimensionChange, transform.position);
        }
		

        if(CurrentDimension != Dimensions.Normal)
        {
            DimensionSound.SetActive(true);
        }
        else
        {
            DimensionSound.SetActive(false);
        }

	}
}
