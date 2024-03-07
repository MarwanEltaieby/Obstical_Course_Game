using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeteorMovement : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float meteorSpeed;
    [SerializeField] private float rotationSpeed;

    private void Start() 
    {

    }

    private void Update() 
    {
        MoveTowardsPlayer();
        MeteorRotation();
    }

    private void MoveTowardsPlayer()
    {
        var step =  meteorSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), step);
    }

    private void MeteorRotation()
    {
        transform.Rotate(new Vector3(1, 1, 0) * Time.deltaTime * rotationSpeed);
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
    }
}
