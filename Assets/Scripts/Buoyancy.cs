using UnityEngine;
using System.Collections;

public class Buoyancy : MonoBehaviour {

    public float UpwardForce = 12.72f;
    public bool IsInWater = false;

    void OnTriggerEnter(Collider collider)
    {
        IsInWater = true;
        rigidbody.drag = 5.0f;
    }

    void OnTriggerExit(Collider collider)
    {
        IsInWater = false;
        rigidbody.drag = 0.05f;
    }

    void FixedUpdate()
    {
        if (IsInWater)
        {
            Vector3 force = transform.up * UpwardForce;
            this.rigidbody.AddRelativeForce(force, ForceMode.Acceleration);
            Debug.Log("Upward force: " + force + " @" + Time.time);
        }
    }
}
