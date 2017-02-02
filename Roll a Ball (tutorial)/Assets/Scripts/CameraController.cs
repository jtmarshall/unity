using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		//Find distance between camera and player
		offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void LateUpdate () {
		//keep updating the position each frame
		transform.position = player.transform.position + offset;
	}
}
