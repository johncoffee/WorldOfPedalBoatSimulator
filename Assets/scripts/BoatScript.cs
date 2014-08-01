using UnityEngine;
using System.Collections;

public class BoatScript : MonoBehaviour {

	public float forwardForce = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Forward() {
		this.rigidbody.AddForce(Vector3.forward * forwardForce);
	}


}
