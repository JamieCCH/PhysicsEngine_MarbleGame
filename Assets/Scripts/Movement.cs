using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField] float accel;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.X)) rb.AddForce(new Vector3(accel*Time.deltaTime, 0, 0));
	}
}
