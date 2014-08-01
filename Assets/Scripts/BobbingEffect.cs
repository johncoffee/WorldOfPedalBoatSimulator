using UnityEngine;
using System.Collections;

public class BobbingEffect : MonoBehaviour {

    public float Steer = 0.0f;

	void Start () 
    {
	
	}
	
	void Update ()
    {
        rigidbody.AddTorque(0.0f, 0.0f, -Steer * 10.0f);
        Quaternion correctRotation = transform.rotation;
        correctRotation.z = Mathf.Clamp(correctRotation.z, -15.0f * Mathf.Deg2Rad, 15.0f * Mathf.Deg2Rad);
        transform.rotation = correctRotation;

        Vector3 angularVelocity = rigidbody.angularVelocity;
        angularVelocity.z = Mathf.Clamp(angularVelocity.z, -1.0f, 1.0f);
        rigidbody.angularVelocity = angularVelocity;
	}
}
