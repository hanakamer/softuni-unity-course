using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject target;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;

	public int cur;


	public float flow_speed = 0.02F;
	private Quaternion oldRot;
	private Quaternion newRot;
	void Start () {
		cur = GameObject.Find("capsule").GetComponent<CapsuleScript>().current;

	}
	void Update () {
		cur = GameObject.Find("capsule").GetComponent<CapsuleScript>().current;
		if(cur<4){
			RotateSlowly (enemy1);
		} else if(cur>3 && cur<5){
			RotateSlowly (enemy2);
		} else if(cur>4 && cur<8){
			RotateSlowly (enemy3);
		} else if(cur>8 && cur<10){
			RotateSlowly (enemy4);
		} else if(cur>9){
			RotateSlowly (enemy5);
		} 

	}

	void RotateSlowly(GameObject enemy){
		oldRot   = transform.rotation ;
		transform.LookAt ( enemy.transform ) ;
		newRot   = transform.rotation ;
		transform.rotation = Quaternion.Lerp ( oldRot , newRot, flow_speed ) ;
	}
}
