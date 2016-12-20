using UnityEngine;
using System.Collections;

public class TakeWeapon : MonoBehaviour, IGvrGazeResponder {

	private bool isInside = false;
	private bool tipOn = false;
	private float distance;
	public GameObject selectObject;
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
		if ((distance < 2.5) && (tipOn == false) && (isInside == true)) {
			AnimTip.SetTrigger ("FadeIn");
			tipOn = true;
		} 
		if ((distance > 2.5) && (tipOn == true) && (isInside == false)) {
			AnimTip.SetTrigger ("FadeOut");
			tipOn = false;
		}
		if (isInside == true) {
			if (Input.GetButtonDown ("Fire1")) {
				if (gameObject.GetComponent<MeshRenderer> ().enabled == true) {
					gameObject.GetComponent<MeshRenderer> ().enabled = false;
					selectObject.SetActive (true);
				} else {
					gameObject.GetComponent<MeshRenderer> ().enabled = true;
					selectObject.SetActive (false);
				}
			}
		}
		

	}

}
