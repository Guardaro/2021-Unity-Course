using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    void Update()
    {
        Vector3 moveThisFrame = transform.forward * moveSpeed * Time.deltaTime;
        transform.position += moveThisFrame;
    }
}
