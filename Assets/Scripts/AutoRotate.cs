using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] Vector3 rotationPerSecond;

    void Update()
    {
        Transform rotor;
        rotor = GetComponent<Transform>();

        Vector3 rotationThisFrame = rotationPerSecond * Time.deltaTime;
        rotor.Rotate(rotationThisFrame);
    }
}
