using UnityEngine;
using System.Collections;

public class BoatMovementController : MonoBehaviour {

	public float forwardForce = 10f;
	public float turnSpeed = 1;

	public float maxSpeed = 7.5f;

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

//		Debug.Log(rigidbody.velocity.magnitude);
	}


	public void Forward() {
		if (rigidbody.velocity.magnitude < maxSpeed) {
			this.rigidbody.AddForce(transform.forward * forwardForce);
		}
	}

	public void Backward() {
		this.rigidbody.AddForce(transform.forward * -forwardForce);
	}
	
	public void TurnLeft() {
		float mag = Mathf.Min(rigidbody.velocity.magnitude, 5);
		float _turnSpeed = mag/5f * turnSpeed;
		transform.Rotate(0, -_turnSpeed, 0);
	}
	
	
	public void TurnRight() {
//		rigidbody.AddRelativeTorque(new Vector3(0f,turnSpeed*Time.deltaTime,0f));
		
		float mag = Mathf.Min(rigidbody.velocity.magnitude, 5);
		float _turnSpeed = mag/5f * turnSpeed;
		transform.Rotate(0, _turnSpeed, 0);
	}

}
