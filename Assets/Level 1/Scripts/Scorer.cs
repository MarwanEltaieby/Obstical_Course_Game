using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = -1;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Hit") {
            Debug.Log("Score: " + ++score);
        }
    }
}
