using UnityEngine;
using System.Collections;

public class rotation_sun : MonoBehaviour {
private float rot_speed;
	// Use this for initialization
	void Start () {
	rot_speed = Random.Range(6f,10f);
	}
	
	// Update is called once per frame
	void Update () {
	this.transform.Rotate(Vector3.up,Time.deltaTime*rot_speed);
	}
}
