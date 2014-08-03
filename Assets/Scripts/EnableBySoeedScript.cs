using UnityEngine;
using System.Collections;

public class EnableBySoeedScript : MonoBehaviour {

	public ParticleSystem ps;
	public float psSpeed = 2f;

	Rigidbody _rigidbody;

	void Start() {
		_rigidbody = this.transform.parent.GetComponent<Rigidbody>();
		ps = this.GetComponent<ParticleSystem>();
	}


	void Update () {

		if (_rigidbody.velocity.magnitude > psSpeed) {
			ps.enableEmission = true;
		}
		else {
			ps.enableEmission = false;
		}
	}
}
