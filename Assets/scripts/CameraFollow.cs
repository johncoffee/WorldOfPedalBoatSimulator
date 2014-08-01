using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject[] targets;

	public float offsetZ = 20f;
	public float offsetY = 20f;

	void Start () {
	}

	void follow ()
	{
		Vector3 median = new Vector3();

		if (targets.Length > 0) {
			for (int i = 0; i < targets.Length; i++) {
				Transform t = targets[i].transform;
				median += t.position;
			}
		}

		median /= targets.Length;	

		transform.position = new Vector3(transform.position.x, median.y + offsetY, median.z + offsetZ);
	}
	
	void Update () {
		follow();
	}

}
