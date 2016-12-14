using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour, IGvrGazeResponder {
	
	private bool isInside = false;
	private bool tipOn = false;
	private float distance;
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

				if (!(transform.FindChild ("fl_candle_light").gameObject.activeInHierarchy)) {
					transform.FindChild ("fl_candle_light").gameObject.SetActive (true);
				} else {
					transform.FindChild ("fl_candle_light").gameObject.SetActive (false);
				}

			}
		}
	}
}
