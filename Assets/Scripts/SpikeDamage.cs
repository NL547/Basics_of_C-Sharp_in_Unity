using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    public int damage = 100;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player" && !coll.GetComponent<HP>().immortaly)
        {
            coll.GetComponent<HP>().hp -= (damage);
        }
    }
}
