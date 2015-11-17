using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {
	public bool grounded;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter(Collision ground)
	{
		if (ground.gameObject.tag == "Spike")
		{
			Application.LoadLevel (0);
		}
		if (ground.gameObject.tag == "Ground")
		{
			grounded = true;
		}

		else{ grounded = false;}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
