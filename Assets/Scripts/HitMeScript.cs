using UnityEngine;
using System.Collections;

public class HitMeScript : MonoBehaviour {

	float kickForce = 2000f;

	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		GameObject otherGameObject = other.gameObject;

		if (otherGameObject.GetComponent<HitMeScript>() != null) {

			float v1 = this.transform.parent.rigidbody.velocity.magnitude;
			float v2 = otherGameObject.transform.parent.rigidbody.velocity.magnitude;



			float maxSpeed = Mathf.Min(4, v1);
			float _kickForce = kickForce * (maxSpeed/4f);

			if (v1 > v2) {
				otherGameObject.transform.parent.rigidbody.AddForce( transform.forward * _kickForce );
			}
		}
	}
}
