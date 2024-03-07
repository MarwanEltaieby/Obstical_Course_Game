using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    // Start is called before the first frame update
    void Start() {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update() {
        MovePlayer();
    }

    void PrintInstructions() {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move Your player with WASD or Arrow Keys.");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float yValue = 0;
        transform.Translate(xValue, yValue, zValue);
    }
}
