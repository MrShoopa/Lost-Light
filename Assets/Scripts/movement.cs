using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
public class movement : MonoBehaviour
{
	private PlayerControls controls;
	public GameManager manager;
	static public float speed = 3;
	public Rigidbody rb;
	Vector2 move;
	Vector3 JumpForce = new Vector3(0, 5, 0);
	bool jumpUsed = false;
	bool onGround = true;
	private bool canMove = true;
	private int curCheckpoint = 0;
	private Vector3 respawn;
	void Awake()
	{
		controls = new PlayerControls();
		controls.Side.Toggle.performed += ctx => PerspectiveToggle();
		controls.Side.Jump.performed += ctx => JumpToggle();
		controls.Side.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
		controls.Side.Move.canceled += ctx => move = Vector2.zero;
		respawn = transform.position;
	}

	void OnEnable()
	{
		controls.Side.Enable();
	}
	void OnDisable()
	{
		controls.Side.Disable();
	}
	void Update()
	{
		Vector3 m;
		if (canMove)
		{
			if (FindObjectOfType<GameManager>().getPerspective() == GameManager.Perspective.threeD)
			{
				m = new Vector3(move.y, 0, -move.x) * speed * Time.deltaTime;
			}
			else // 2D
			{
				m = new Vector3(move.x, 0, 0) * speed * Time.deltaTime;
			}

			if (jumpUsed && onGround)
			{
				rb.AddForce(JumpForce, ForceMode.Impulse);
				onGround = false;
			}
			transform.Translate(m, Space.World);
		}
	}
	void PerspectiveToggle()
	{
		toggleMove();
		StartCoroutine(FindObjectOfType<GameManager>().updatePerspective());
		Invoke("toggleMove", 2f);
	}
	void toggleMove()
	{
		canMove = !canMove;
	}
	void JumpToggle()
	{
		jumpUsed = true;
	}
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Ground" || collision.gameObject.name.Contains("Plat"))
		{
			onGround = true;
			jumpUsed = false;
		}
	}
	private void resetPos()
	{
		transform.position = respawn;
	}
	private void OnTriggerEnter(Collider collide)
	{
		if (collide.tag == "Checkpoint")
		{
			if (Int32.Parse(collide.name) > curCheckpoint)
			{
				respawn = transform.position;
				StartCoroutine(FindObjectOfType<GameManager>().updateCheckpoint(curCheckpoint));
				curCheckpoint += 1;
			}
		}
		else if (collide.tag == "fallNet")
		{
			StartCoroutine(FindObjectOfType<GameManager>().dead());
			Invoke("resetPos", 1f);
		}
		else if (collide.tag == "Finish")
		{
			manager.CompleteLevel();
		}
	}
}
