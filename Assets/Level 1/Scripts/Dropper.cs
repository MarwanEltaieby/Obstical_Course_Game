using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer myRenderer;
    Rigidbody myBody;
    [SerializeField] float timeTrigger = 3f;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeTrigger) {
            myRenderer.enabled = true;
            myBody.useGravity = true;
        }
    }
}
