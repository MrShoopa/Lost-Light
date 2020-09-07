using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

	public Transform player;    // A variable that stores a reference to our Player
	private Vector3 offset;     // A variable that allows us to offset the position (x, y, z)
	private Vector3 Offset2D = new Vector3(0, 3, -10);
	private Vector3 Rot2D = new Vector3(0, 0, 0);

	private Vector3 Offset3D = new Vector3(-3, 2, 0);
	private Vector3 Rot3D = new Vector3(10, 90, 0);
	public bool in3D = false;

	// Update is called once per frame
	void Update()
	{
		// Set our position to the players position and offset it
		transform.position = player.position + offset;
	}
	void FixedUpdate()
	{
		if (FindObjectOfType<GameManager>().getPerspective() == GameManager.Perspective.threeD)
		{
			transform.rotation = Quaternion.Euler(Rot3D);
			offset = Offset3D;
		}
		else
		{
			transform.rotation = Quaternion.Euler(Rot2D);
			offset = Offset2D;
		}
	}
}
