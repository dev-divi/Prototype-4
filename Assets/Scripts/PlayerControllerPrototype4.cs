using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPrototype4 : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f; 

    private GameObject focalPoint;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); 
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        //playerRb.AddForce(Vector3.forward * speed * forwardInput); v1 
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput); 
    }
}
