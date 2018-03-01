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
    public Enemy9 enemy9;
    public Enemy10 enemy10;
    public Enemy11 enemy11;
    public Enemy12 enemy12;
    public Enemy13 enemy13;
    public Enemy14 enemy14;
    public Enemy15 enemy15;
    public Alien alien;
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
        if (other.tag == "Enemy_9")
        {
            enemy9.GetComponent<Animator>().enabled = false;
            enemy9.actions.SetBool("IdleWhenArrives", true);
            enemy9.counterToShotBool = true;

        }
        if (other.tag == "Enemy_10")
        {
            enemy10.GetComponent<Animator>().enabled = false;
            enemy10.actions.SetBool("IdleWhenArrives", true);
            enemy10.counterToShotBool = true;

        }
        if (other.tag == "Enemy_11")
        {
            enemy11.GetComponent<Animator>().enabled = false;
            enemy11.actions.SetBool("IdleWhenArrives", true);
            enemy11.counterToShotBool = true;

        }
        if (other.tag == "Enemy_12")
        {
            enemy12.GetComponent<Animator>().enabled = false;
            enemy12.actions.SetBool("IdleWhenArrives", true);
            enemy12.counterToShotBool = true;

        }
        if (other.tag == "Enemy_13")
        {
            enemy13.GetComponent<Animator>().enabled = false;
            enemy13.actions.SetBool("IdleWhenArrives", true);
            enemy13.counterToShotBool = true;

        }
        if (other.tag == "Enemy_14")
        {
            enemy14.GetComponent<Animator>().enabled = false;
            enemy14.actions.SetBool("IdleWhenArrives", true);
            enemy14.counterToShotBool = true;

        }
        if (other.tag == "Enemy_15")
        {
            enemy15.GetComponent<Animator>().enabled = false;
            enemy15.actions.SetBool("IdleWhenArrives", true);
            enemy15.counterToShotBool = true;

        }
        if (other.tag == "ALIEN_ALIEN")
        {
            alien.GetComponent<Animator>().enabled = false;
            //alien.actions.SetBool("IdleWhenArrives", true);
            //alien.counterToShotBool = true;

        }

    }
}

