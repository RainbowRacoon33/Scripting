using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpBoost = 8f;
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength += jumpBoost;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength -= jumpBoost;
    }

}
