using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int currentBumpCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            Debug.Log("Oh I hit something! Count: " + (++currentBumpCount).ToString());
        }
    }
}
