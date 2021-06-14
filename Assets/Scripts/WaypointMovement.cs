using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
	[SerializeField] Transform[] waypoints;
	[SerializeField] float moveSpeed = 4f;

	int currentWaypoint = 0;

	private void Update()
	{
		Transform waypoint = waypoints[currentWaypoint];
		Vector3 difference = waypoint.position - transform.position;

		float moveThisFrame = moveSpeed * Time.deltaTime;
		float distanceToWaypoint = difference.magnitude;

		if(moveThisFrame < distanceToWaypoint)
		{
			Vector3 movementThisFrameVector = moveThisFrame * difference.normalized;
			transform.position = transform.position + movementThisFrameVector;
		}
		else
		{
			transform.position = waypoints[currentWaypoint].position;

			currentWaypoint = currentWaypoint + 1;
			if(currentWaypoint >= waypoints.Length)
			{
				currentWaypoint = 0;
			}
		}
	}
}
