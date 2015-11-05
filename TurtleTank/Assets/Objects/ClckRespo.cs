using UnityEngine;
using System.Collections;

public class ClckRespo : MonoBehaviour {

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
}
