using UnityEngine;
using System.Collections;

public class BoatMovementController : MonoBehaviour {

	public float forwardForce = 10f;
	public float turnSpeed = 1;

	bool turnLeft;
	bool turnRight;

	public KeyCode turnLeftKey = KeyCode.A;
	public KeyCode turnRightKey = KeyCode.D;

	void Start () {
	
	}
	
	void Update () {
	
		turnLeft = Input.GetKey(turnLeftKey);
		turnRight = Input.GetKey(turnRightKey);

		// rotation
		if (turnLeft) {
			TurnLeft();
		}
		else if (turnRight) {
			TurnRight();
		}
		else {
			// damp off velocity
			rigidbody.angularVelocity *= (0.99f * Time.fixedDeltaTime);		
		}

	}


	public void Forward() {
		this.rigidbody.AddForce(transform.forward * forwardForce);
	}
	
	public void TurnLeft() {
		transform.Rotate(0, -turnSpeed, 0);
	}
	
	
	public void TurnRight() {
//		rigidbody.AddRelativeTorque(new Vector3(0f,turnSpeed*Time.deltaTime,0f));
		transform.Rotate(0, turnSpeed, 0);
	}

}
