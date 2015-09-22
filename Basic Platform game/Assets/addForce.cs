using UnityEngine;
using System.Collections;

public class addForce : MonoBehaviour {

	public float speed = 5.0f;
	public float jumpspeed = 7.0f;
	public float maxJump = 3.0f;
	bool isGrounded = false;
	public int jumpCount = 1;
	public Vector3 startPos;
	
	
	
	
	// Use this for initialization
	void Start () {
		startPos=transform.position;
	}
	
	void OnCollisionEnter(Collision collision)
	{
		
		if (collision.gameObject.tag == "Ground") 
		{
			jumpCount = 1;
			isGrounded = true;

		} 
		
		if (collision.gameObject.tag == "death")
		{
			jumpCount = 1;
			transform.position=startPos;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//Code to move the cube when the game starts with no control input
		
		//grounding function
		
		
		
		//Basic moving
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
		
		
		//Crouching

		
		//Jumping
		if (Input.GetKeyDown (KeyCode.Space) && maxJump > jumpCount)
		{
			GetComponent <Rigidbody> ().velocity += Vector3.up * jumpspeed;
			jumpCount++;
			isGrounded = false;
			
		}
		
		
		if (jumpCount > maxJump && isGrounded == true) 
		{
			jumpspeed = 0.0f;
			jumpCount = 1;
		}
		
		//Next Assignment: Crouch, Death Volumes and Reset Life/Location.
	}
	
}
