using UnityEngine;
using System.Collections;

public class BoatGravity : MonoBehaviour {

    public Vector3 Gravity;
    public float Force;

    void Start()
    {
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(Gravity * Force);
    }
}
