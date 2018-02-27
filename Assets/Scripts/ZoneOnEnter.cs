using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using DG.Tweening;
using UnityEngine.UI;

public class ZoneOnEnter : MonoBehaviour
{
    public Enemy1 enemy1;
    public Enemy2 enemy2;
    public Enemy3 enemy3;
    public Enemy4 enemy4;
    public Enemy5 enemy5;
    public Enemy6 enemy6;
    public Enemy7 enemy7;
    public Enemy8 enemy8;
    //Update
    void Update()
    {
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy_1")
        {
            enemy1.GetComponent<Animator>().enabled = false;
            enemy1.actions.SetBool("IdleWhenArrives", true);
            enemy1.counterToShotBool = true;
            
        }

        if (other.tag == "Enemy_2")
        {
            enemy2.GetComponent<Animator>().enabled = false;
            enemy2.actions.SetBool("IdleWhenArrives", true);
            enemy2.counterToShotBool = true;

        }

        if (other.tag == "Enemy_3")
        {
            enemy3.GetComponent<Animator>().enabled = false;
            enemy3.actions.SetBool("IdleWhenArrives", true);
            enemy3.counterToShotBool = true;

        }

        if (other.tag == "Enemy_4")
        {
            enemy4.GetComponent<Animator>().enabled = false;
            enemy4.actions.SetBool("IdleWhenArrives", true);
            enemy4.counterToShotBool = true;

        }

        if (other.tag == "Enemy_5")
        {
            enemy5.GetComponent<Animator>().enabled = false;
            enemy5.actions.SetBool("IdleWhenArrives", true);
            enemy5.counterToShotBool = true;

        }

        if (other.tag == "Enemy_6")
        {
            enemy6.GetComponent<Animator>().enabled = false;
            enemy6.actions.SetBool("IdleWhenArrives", true);
            enemy6.counterToShotBool = true;

        }

        if (other.tag == "Enemy_7")
        {
            enemy7.GetComponent<Animator>().enabled = false;
            enemy7.actions.SetBool("IdleWhenArrives", true);
            enemy7.counterToShotBool = true;

        }

        if (other.tag == "Enemy_8")
        {
            enemy8.GetComponent<Animator>().enabled = false;
            enemy8.actions.SetBool("IdleWhenArrives", true);
            enemy8.counterToShotBool = true;

        }
    }
}

