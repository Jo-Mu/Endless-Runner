﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public PlayerControl thePlayer;

	private float height;
	private Vector3 lastPlayerPosition;
	private float distanceToMove;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerControl> ();
		height = thePlayer.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 moveTo = thePlayer.transform.position;
		moveTo.y = height;
		moveTo.z = 2;
		transform.position = new Vector3(thePlayer.transform.position.x, transform.position.y, transform.position.z);
	}
}
