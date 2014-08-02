using UnityEngine;
using System.Collections;

public class SeaSicknessScript : MonoBehaviour {

	public float magnitude = 0.01f;
	public float rmagnitude = 1.6f;

	public float ySpeed = 1.9f;

	public float rSpeed = 2.1f;

	public float staticOffsetRX = 25f;

	float timeOffset;

	void Start () {

		timeOffset = Random.value * 10f;
	}
	
	void Update () {
		float y = Mathf.Sin( Time.realtimeSinceStartup * ySpeed ) * magnitude;
		transform.position += new Vector3( 0, y, 0);

		float r = Mathf.Sin( timeOffset + Time.realtimeSinceStartup * rSpeed ) * rmagnitude;

		float ny = transform.rotation.y;
		float nx = staticOffsetRX;
		transform.localRotation = Quaternion.Euler( nx, ny, r );
	}

}
