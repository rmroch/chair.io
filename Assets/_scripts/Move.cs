using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public float strength;

    Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("UpArrow");
            Vector3 v3Force = strength * transform.forward;
            rb.AddForce(v3Force);
        }
	}
}
