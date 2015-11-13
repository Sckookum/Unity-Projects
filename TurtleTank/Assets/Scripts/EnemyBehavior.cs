using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void onTriggerEnter (Collider point)
	{
	 if(point.tag == "Cursor")
		{
			DestroyObject(gameObject);
		}
	}
}
