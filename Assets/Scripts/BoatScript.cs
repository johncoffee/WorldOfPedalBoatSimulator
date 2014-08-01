using UnityEngine;
using System.Collections;

public class BoatScript : MonoBehaviour {

    public float SeaLevel = 0.0f;
    public float Bob = 0.1f;
    public float BobFrequency = 0.2f;

    private float _Elapsed = 0.0f;

	void Start () {
	
	}
	
	void Update ()
    {
        _Elapsed += Time.deltaTime;

        Vector3 position = transform.position;
        position.y = SeaLevel + Bob * Mathf.Sin(_Elapsed * BobFrequency * (Mathf.PI * 2));
        transform.position = position;
	}
}
