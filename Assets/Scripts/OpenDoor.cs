﻿using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour, IGvrGazeResponder {

	private bool isOpen = false;
	private bool isInside = false;
	private bool tipOn = false;
	private float distance;
	public Animator AnimDoor;
	public Animator AnimTip;
	public Transform player;
	public Transform thisObject;

	public void OnGazeEnter(){
		isInside = true;

	}

	public void OnGazeExit(){
		isInside = false;

	}

	public void OnGazeTrigger(){

	}

	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
	}


	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(player.position, thisObject.position);
		if ((distance < 2.5) && (tipOn == false)) {
			AnimTip.SetTrigger ("FadeIn");
			tipOn = true;
		} 
		if ((distance > 2.5) && (tipOn == true)) {
			AnimTip.SetTrigger ("FadeOut");
			tipOn = false;
		}
		if (isInside == true) {
			if (Input.GetButtonDown ("Fire1")) {
				if (isOpen == false) {
					AnimDoor.SetBool ("OpenDoor", true);
					isOpen = true;
				} else {
					AnimDoor.SetBool ("OpenDoor", false);
					isOpen = false;
				}
				
			}
		}
	}
}