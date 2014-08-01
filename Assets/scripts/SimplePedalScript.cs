using UnityEngine;
using System.Collections;

public class SimplePedalScript : MonoBehaviour
{

		GameObject go;
		public KeyCode leftKey, rightKey;
		public BoatMovementController boat;
		bool halfWayThere = false;

		void Start ()
		{
				if (boat == null)
						Debug.LogWarning ("boat not set");
		}

		void Update ()
		{

				if (Input.GetKeyDown (leftKey)) {
						poke ();
				} else if (Input.GetKeyDown (rightKey)) {
						poke ();
				}
		}

		void poke ()
		{
				if (halfWayThere) {
						boat.Forward ();
				}
				halfWayThere = !halfWayThere;
		}
}
