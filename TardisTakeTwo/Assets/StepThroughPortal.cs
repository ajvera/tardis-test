using UnityEngine;
using System.Collections;

public class stepThroughPortal : MonoBehaviour {
	
	public GameObject otherPortal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter(Collider other) {
		Debug.Log("trigger function");
//		if (other.tag == "Player") {
//			other.transform.position = otherPortal.transform.position;
//		}
	}
}
