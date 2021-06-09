using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    string xAxis = "Horizontal";
    CharacterController myController;

	private void Start()
	{
        myController = GetComponent<CharacterController>();
	}

	void Update()
    {
        float xInput = 0f;
        xInput = Input.GetAxis(xAxis);

        Vector3 moveVector = Vector3.zero;
        moveVector.x = xInput * moveSpeed * Time.deltaTime;

        myController.Move(moveVector);
    }
}
