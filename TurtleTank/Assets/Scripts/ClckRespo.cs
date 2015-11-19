using UnityEngine;
using System.Collections;

public class ClckRespo : MonoBehaviour {

	public float jumpForce = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Dragging ();
	}
	void OnMouseDown()
	{

	}
	void Dragging() 
	{
		Vector3 mouseWorldPoint = Input.mousePosition;
		mouseWorldPoint.z = Camera.main.transform.position.z * -1;
		mouseWorldPoint = Camera.main.ScreenToWorldPoint(mouseWorldPoint);
		transform.position = mouseWorldPoint;
	}
	//Cursor.attachedRigidbody - this could be used as a test condition.
	void OnTriggerStay (Collider Cursor)
	{
		if (Cursor.tag == "Player" && Input.GetMouseButton(0)) 
		{
		
			Cursor.attachedRigidbody.velocity = (Vector3.up * jumpForce);
		}
		if (Cursor.tag == "enemy" && Input.GetMouseButton(0)) 
		{
			Destroy (Cursor.gameObject);
		}
	}
}
