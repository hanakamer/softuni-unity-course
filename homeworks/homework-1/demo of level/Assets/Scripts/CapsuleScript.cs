using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour {
	public Transform[] target;
	public float speed;

	public int current;

	void Start () {
		
	}
		void Update () {
		Debug.Log (transform.position +" "+ target[current].position);

		if (transform.position != target [current].position) {
			Vector3 pos = Vector3.MoveTowards (transform.position, target [current].position, speed * Time.deltaTime);
			GetComponent<Rigidbody> ().MovePosition (pos);

		} else {
			if (current < 10) {
				current = (current + 1);
			} else {
				speed =  0;
			}
		}
		
		
	}
}
