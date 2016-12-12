using UnityEngine;
using System.Collections;

public class TakeWeapon : MonoBehaviour {

	public GameObject SelectObject;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

	}

	public void Take() {
		if (gameObject.GetComponent<MeshRenderer>().enabled == true) {
			gameObject.GetComponent<MeshRenderer>().enabled = false;
			SelectObject.SetActive (true);
		} else {
			gameObject.GetComponent<MeshRenderer>().enabled = true;
			SelectObject.SetActive (false);
		}
	}
}
