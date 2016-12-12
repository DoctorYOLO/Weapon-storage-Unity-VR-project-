using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void SwitchOn() {
		if (!(transform.FindChild ("fl_candle_light").gameObject.activeInHierarchy)) {
			transform.FindChild ("fl_candle_light").gameObject.SetActive (true);
		} else {
			transform.FindChild("fl_candle_light").gameObject.SetActive(false);
		}
	}
		
}
