using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ObstacleSwitch : MonoBehaviour
{
	private static float sideviewDefaultZAxis = -4.5f; //Readjust when moving Level Object

	private Vector3 OriginalPos, MovedPos;

	// Start is called before the first frame update
	void Start()
	{
		OriginalPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		MovedPos = new Vector3(transform.position.x, transform.position.y, sideviewDefaultZAxis);
	}


	public void SwitchPerspective()
	{
		if (FindObjectOfType<GameManager>().getPerspective() == GameManager.Perspective.twoD)
		{
			transform.position = MovedPos;
		}
		else if (FindObjectOfType<GameManager>().getPerspective() == GameManager.Perspective.threeD)
		{
			transform.position = OriginalPos;
		}
	}
}
