using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using DG.Tweening;
using UnityEngine.UI;

public class ZoneOnEnter : MonoBehaviour
{
    public Enemy1 enemy1;

    //Update
    void Update()
    {
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy_123")
        {
            enemy1.GetComponent<Animator>().enabled = false;
            enemy1.actions.SetBool("IdleWhenArrives", true);
            enemy1.counterToShotBool = true;
            
        }
    }
}

