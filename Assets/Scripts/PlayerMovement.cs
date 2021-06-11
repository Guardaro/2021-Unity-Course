using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float gravity = -40f;
    [SerializeField] float jumpSpeed = 10f;
    [SerializeField] AudioClip jumpSoundEffect;

    AudioSource audioSource;

    float ySpeed = 0f;

    string xAxis = "Horizontal";
    string zAxis = "Vertical";
    string jumpButton = "Jump";

    CharacterController myController;

	private void Start()
	{
        myController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
	}

	void Update()
    {
        float xInput = Input.GetAxis(xAxis);
        float zInput = Input.GetAxis(zAxis);
        bool jumpButtonPressed = Input.GetButtonDown(jumpButton);

        ySpeed = ySpeed + gravity * Time.deltaTime;

        if (jumpButtonPressed)
		{
			if (myController.isGrounded)
			{
                ySpeed = jumpSpeed;
                audioSource.PlayOneShot(jumpSoundEffect);
            }
        }

        Vector3 moveVector = Vector3.zero;


        moveVector.x = xInput * moveSpeed * Time.deltaTime;
        moveVector.z = zInput * moveSpeed * Time.deltaTime;

        //Vector3 relativeHorizontalMovement = xInput * moveSpeed * Time.deltaTime * transform.right;
        //Vector3 relativeForwardMovement = zInput * moveSpeed * Time.deltaTime * transform.forward;
        //moveVector = moveVector + relativeForwardMovement;
        //moveVector = moveVector + relativeHorizontalMovement;

        moveVector.y = ySpeed * Time.deltaTime;

        myController.Move(moveVector);

		if (myController.isGrounded)
		{
            ySpeed = 0f;
		}
    }
}
