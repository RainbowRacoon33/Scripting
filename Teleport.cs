using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject teleportingPoint;

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportingPoint.transform.position;
    }
}
