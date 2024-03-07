using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    private static int score = 0;

    private void OnCollisionEnter(Collision other) 
    {
        switch (other.gameObject.tag) 
        {
            case "Player":
                score--;
                break;
            default:
                score++;
                break;
        }
    }

    public static int GetScore()
    {
        return score;
    }
}
