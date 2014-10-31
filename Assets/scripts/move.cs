
using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float moveSpeed = 1200f;  


	void Update () {

		//rigidbody.AddForce ( transform.forward * Time.deltaTime * moveSpeed );
		rigidbody.AddForce ( transform.forward * Time.deltaTime * moveSpeed );

		if (Physics.Raycast ( transform.position, transform.forward, 10f  ) ) {
			transform.Rotate (0f, Mathf.Sign ( Random.Range (-1f, 1f) ) * 90f, 0f );
		}

	}
}





