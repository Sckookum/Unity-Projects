using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	public bool collision = false;
	public Rigidbody body;
	public float jumpHeight = 0;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			transform.Translate(0,3,0);
		}

	}

}
