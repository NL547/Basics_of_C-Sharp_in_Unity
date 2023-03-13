using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class HP : MonoBehaviour
{
    public GameObject Player;
    public GameObject Canvas;
    public int hp = 100;
    public bool immortaly;
    
    void Update()
    {
        if (hp > 100)
        {
            hp = 100;
        }
        if (hp < 1)
        {
            Player.SetActive(false);
            Canvas.SetActive(true);
        }
    }

    private void ResetImmortaly()
    {
        immortaly = false;        
        transform.GetChild(0).gameObject.SetActive(false);
    }

    void OnTriggerStay(Collider coll)
    {
        if (coll.tag == "ImmortalyItem")
        {
            immortaly = true;
            Destroy(coll.gameObject);
            transform.GetChild(0).gameObject.SetActive(true);
            Invoke(nameof(ResetImmortaly), 10f);
        }
    }
}
