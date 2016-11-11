using UnityEngine;
using System.Collections;

public class Transport : MonoBehaviour {

	public GameObject otherPortal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 1;
		}
	}
}
