using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 2;

    private Rigidbody componentRigidbody;

    void Start()
    {
        componentRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        componentRigidbody.velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.A)) componentRigidbody.velocity += Vector3.left * Speed;
        if (Input.GetKey(KeyCode.D)) componentRigidbody.velocity += Vector3.right * Speed;
        if (Input.GetKey(KeyCode.W)) componentRigidbody.velocity += Vector3.forward * Speed;
        if (Input.GetKey(KeyCode.S)) componentRigidbody.velocity += Vector3.back * Speed;        
    }
}
