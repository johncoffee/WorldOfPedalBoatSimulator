using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			Application.LoadLevel(0);
		}
	}

	void OnTriggerEnter() {
		Debug.Log("Player something has won");
	}
}
