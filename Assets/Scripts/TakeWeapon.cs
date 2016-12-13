using UnityEngine;
using System.Collections;

public class TakeWeapon : MonoBehaviour, IGvrGazeResponder {

	private bool isInside = false;
	public GameObject selectObject;

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
