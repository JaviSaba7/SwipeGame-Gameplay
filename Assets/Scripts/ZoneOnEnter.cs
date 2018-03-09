using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using DG.Tweening;
using UnityEngine.UI;

public class ZoneOnEnter : MonoBehaviour
{
    public Enemy1 enemy1;
    public GameObject enemy1_anim;
    public GameObject enemy2_anim;
    public GameObject enemy3_anim;
    public GameObject enemy4_anim;
    public GameObject enemy5_anim;
    public GameObject enemy6_anim;
    public GameObject enemy7_anim;
    public GameObject enemy8_anim;
    public GameObject enemy9_anim;
    public GameObject enemy10_anim;
    public GameObject enemy11_anim;
    public GameObject enemy12_anim;
    public GameObject enemy13_anim;
    public GameObject enemy14_anim;
    public GameObject enemy15_anim;
    public GameObject alien_anim;





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
            Debug.Log("ENTER!");
            enemy1_anim.GetComponent<Animator>().enabled = false;
            enemy1.actions.SetBool("IdleWhenArrives", true);
            enemy1.counterToShotBool = true;
            
        }

        if (other.tag == "Enemy_2")
        {
            enemy2_anim.GetComponent<Animator>().enabled = false;
            enemy2.actions.SetBool("IdleWhenArrives", true);
            enemy2.counterToShotBool = true;

        }

        if (other.tag == "Enemy_3")
        {
            enemy3_anim.GetComponent<Animator>().enabled = false;
            enemy3.actions.SetBool("IdleWhenArrives", true);
            enemy3.counterToShotBool = true;

        }

        if (other.tag == "Enemy_4")
        {
            enemy4_anim.GetComponent<Animator>().enabled = false;
            enemy4.actions.SetBool("IdleWhenArrives", true);
            enemy4.counterToShotBool = true;
        }

        if (other.tag == "Enemy_5")
        {
            enemy5_anim.GetComponent<Animator>().enabled = false;
            enemy5.actions.SetBool("IdleWhenArrives", true);
            enemy5.counterToShotBool = true;
        }

        if (other.tag == "Enemy_6")
        {
            enemy6_anim.GetComponent<Animator>().enabled = false;
            enemy6.actions.SetBool("IdleWhenArrives", true);
            enemy6.counterToShotBool = true;

        }

        if (other.tag == "Enemy_7")
        {
            enemy7_anim.GetComponent<Animator>().enabled = false;
            enemy7.actions.SetBool("IdleWhenArrives", true);
            enemy7.counterToShotBool = true;

        }

        if (other.tag == "Enemy_8")
        {
            enemy8_anim.GetComponent<Animator>().enabled = false;
            enemy8.actions.SetBool("IdleWhenArrives", true);
            enemy8.counterToShotBool = true;

        }
        if (other.tag == "Enemy_9")
        {
            enemy9_anim.GetComponent<Animator>().enabled = false;
            enemy9.actions.SetBool("IdleWhenArrives", true);
            enemy9.counterToShotBool = true;

        }
        if (other.tag == "Enemy_10")
        {
            enemy10_anim.GetComponent<Animator>().enabled = false;
            enemy10.actions.SetBool("IdleWhenArrives", true);
            enemy10.counterToShotBool = true;

        }
        if (other.tag == "Enemy_11")
        {
            enemy11_anim.GetComponent<Animator>().enabled = false;
            enemy11.actions.SetBool("IdleWhenArrives", true);
            enemy11.counterToShotBool = true;

        }
        if (other.tag == "Enemy_12")
        {
            enemy12_anim.GetComponent<Animator>().enabled = false;
            enemy12.actions.SetBool("IdleWhenArrives", true);
            enemy12.counterToShotBool = true;

        }
        if (other.tag == "Enemy_13")
        {
            enemy13_anim.GetComponent<Animator>().enabled = false;
            enemy13.actions.SetBool("IdleWhenArrives", true);
            enemy13.counterToShotBool = true;

        }
        if (other.tag == "Enemy_14")
        {
            enemy14_anim.GetComponent<Animator>().enabled = false;
            enemy14.actions.SetBool("IdleWhenArrives", true);
            enemy14.counterToShotBool = true;

        }
        if (other.tag == "Enemy_15")
        {
            enemy15_anim.GetComponent<Animator>().enabled = false;
            enemy15.actions.SetBool("IdleWhenArrives", true);
            enemy15.counterToShotBool = true;

        }
        if (other.tag == "Enemy_16")
        {
            Debug.Log("ALIEN STOP!");
            alien_anim.GetComponent<Animator>().enabled = false;
            //alien.actions.SetBool("IdleWhenArrives", true);
            //alien.counterToShotBool = true;

        }

    }
}

