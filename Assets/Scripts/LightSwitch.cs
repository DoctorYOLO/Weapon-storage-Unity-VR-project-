using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour, IGvrGazeResponder {
	
	private bool isInside = false;

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

				if (!(transform.FindChild ("fl_candle_light").gameObject.activeInHierarchy)) {
					transform.FindChild ("fl_candle_light").gameObject.SetActive (true);
				} else {
					transform.FindChild ("fl_candle_light").gameObject.SetActive (false);
				}

			}
		}
	}
}
