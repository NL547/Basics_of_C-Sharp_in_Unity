using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject PlayerMovement;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Canvas.SetActive(true);
            coll.GetComponent<PlayerMovement>().moveSpeed = 0.001f;
        }
    }
}
