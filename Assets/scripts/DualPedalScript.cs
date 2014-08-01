using UnityEngine;
using System.Collections;

public class DualPedalScript : MonoBehaviour {

	public KeyCode leftKey, rightKey;
	
	public BoatScript boat;
	
	bool left, right;
	
	void Start () {
	}
	
	void Update () {
		
		if (Input.GetKeyDown(leftKey)) {
			left = true;
			
			if (right) {
				poke ();
				right = false;
			}
		}
		else if (Input.GetKeyDown(rightKey)) {
			right = true;
			
			if (left) {
				poke ();
				left = false;
			}
		}
	}
	
	void poke() {
		boat.Forward();
	}
}
