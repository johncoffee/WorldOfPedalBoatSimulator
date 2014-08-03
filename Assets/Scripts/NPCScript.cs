using UnityEngine;
using System.Collections;

public class NPCScript : MonoBehaviour {

	public float force = 0.2f;
	public float maxSpeed = 1f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float x = -force + Random.value * force * 2f * Time.deltaTime;
		float z = -force + Random.value * force * 2f * Time.deltaTime;

		this.rigidbody.velocity += new Vector3(x, 0, z);	

		if (this.rigidbody.velocity.magnitude > maxSpeed) {
			Vector3 v = rigidbody.velocity;
			v = v * 0.9f;
			rigidbody.velocity = v;
		}

		if (Random.value > 0.97f) {
			rigidbody.AddRelativeTorque( new Vector3( 0, Random.value * 360f, 0));
		}
	}
}
