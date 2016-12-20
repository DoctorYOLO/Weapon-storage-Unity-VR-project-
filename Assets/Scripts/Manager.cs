using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public GameObject mainObj;
	public GameObject helpObj;
	public GameObject controlsObj;
			
	// Use this for initialization
	void Awake () {
	
	}


	public void pressHelp() {
		Debug.Log ("Help");
		mainObj.SetActive (false);
		helpObj.SetActive (true);

	}

	public void pressControls() {
		Debug.Log ("Controls");
		mainObj.SetActive (false);
		controlsObj.SetActive (true);
	}

	public void pressBack() {
		helpObj.SetActive (false);
		controlsObj.SetActive (false);
		mainObj.SetActive (true);
	}
}
