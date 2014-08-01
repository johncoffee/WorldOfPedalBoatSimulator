using UnityEngine;
using System.Collections;

public class BoatGravity : MonoBehaviour {

    public Buoyancy[] Buoyancies = null;

    void FixedUpdate()
    {
        bool touchingWater = false;

        foreach (Buoyancy b in Buoyancies)
        {
            if (b.IsInWater)
            {
                touchingWater = true;
                break;
            }
        }

        if (!touchingWater)
            rigidbody.AddForce(Physics.gravity * rigidbody.mass);
    }
}
