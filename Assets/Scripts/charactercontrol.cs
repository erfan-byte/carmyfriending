using System;
using UnityEngine;
using UnityEditor;

public class charactercontrol : MonoBehaviour
{   
    public float movementSpeed = 50f;
    public Spawnmanager spawnmanager;
    public float speed = 5.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody.Velocity = Vector3(0, 0, 10);
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        transform.Translate(new Vector3(0, 0, vMovement) * Time.deltaTime);
        transform.Rotate(0.0f, Input.GetAxis("Horizontal") * speed, 0.0f);
    }


    private void OnTriggerEnter(Collider other)
    {
        spawnmanager.SpawnTriggerEntered();
    }
}
