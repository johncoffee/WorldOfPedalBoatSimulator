using UnityEngine;
using System.Collections;

public class CameraScripts : MonoBehaviour {

    private SmoothFollow _Follow;

    public GameObject Sphere;

    public GameObject[] Boats;
    //public GameObject Boat1;
    //public GameObject Boat2;

    public float DistScale = 1.0f;
    public Vector3 Add;
	
    void Start()
    {
        _Follow = GetComponent<SmoothFollow>();
    }

	void Update ()
    {
        //Vector3 abHeading = Boat2.transform.position - Boat1.transform.position;
        //Vector3 perp = Vector3.Cross(abHeading, Vector3.up);
        //Vector3 halfWay = (Boat1.transform.position + Boat2.transform.position) * 0.5f;

        Sphere.transform.position = GetCenterPoint();

        Vector3 p1;
        Vector3 p2;
        float dist;

        GetFarestPoints(out p1, out p2, out dist);

        _Follow.distance = dist / 2.0f;
        _Follow.height = dist;
	}

    Vector3 GetCenterPoint()
    {
        Vector3 center = Vector3.zero;

        foreach (GameObject boat in Boats)
            center += boat.transform.position;

        center /= Boats.Length;
        return center;
    }

    void GetFarestPoints(out Vector3 boat1, out Vector3 boat2, out float oDist)
    {
        Vector3 p1 = Vector3.zero;
        Vector3 p2 = Vector3.zero;
        float maxDist = 0.0f;

        for (int i = 0; i < Boats.Length - 1; ++i)
        {
            for (int j = i + 1; j < Boats.Length; ++j)
            {
                float dist = Vector3.Distance(Boats[i].transform.position, Boats[j].transform.position);

                if (dist > maxDist)
                {
                    maxDist = dist;
                    p1 = Boats[i].transform.position;
                    p2 = Boats[j].transform.position;
                }
            }
        }

        boat1 = p1;
        boat2 = p2;
        oDist = maxDist;
    }
}
