using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform followObject;
    private Vector3 deltaPos;

    void Start()
    {
        deltaPos = transform.position - followObject.position;
    }
   
    void Update()
    {
        transform.position = followObject.position + deltaPos;
    }
}
