using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnZone : MonoBehaviour
{
    public Transform Pos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            other.transform.position = Pos.transform.position;
        }
    }
}
