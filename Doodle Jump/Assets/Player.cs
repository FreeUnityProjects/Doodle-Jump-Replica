using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

	public float movementSpeed = 10f;

	private Vector2 inputVec = Vector2.zero;
	Rigidbody2D rb;

	float movement = 0f;
	
	public void OnMove(InputValue input)
	{
		inputVec = input.Get<Vector2>();
		// moveVec = new Vector3(inputVec.x, 0, inputVec.y);
	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		movement = inputVec.x * movementSpeed;
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}
}
