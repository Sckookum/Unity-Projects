using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {
	public bool grounded = false;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter(Collision ground)
	{
		if (ground.gameObject.tag == "Ground")
		{
			grounded = true;
		}
		if (ground.gameObject.tag == "Spike")
		{
			Application.LoadLevel (0);
		}
		else{ grounded = false;}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
