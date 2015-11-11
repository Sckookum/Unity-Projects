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
		mouseWorldPoint.z = 27f;
		mouseWorldPoint = Camera.main.ScreenToWorldPoint(mouseWorldPoint);
		transform.position = mouseWorldPoint;
	}
	void onTriggerEnter (Collider enemy)
	{
		if (enemy.tag == "enemy")
		{
			enemy.transform.Translate(Vector3.up * 3);
		}
	}
	void OnTriggerStay (Collider Cursor)
	{

		if (Cursor.attachedRigidbody && Cursor.tag == "Player") 
		{
			Cursor.attachedRigidbody.AddForce(Vector3.up * jumpForce);
		}
	}
}
