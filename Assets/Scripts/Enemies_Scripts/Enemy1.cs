﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    public float timeOfDie;
    public GameObject alien1_mesh;
    public GameObject anim_alien1;
    public bool timeOfShot;
    public bool startEnemy;
    public float counterToRun;
    public bool counterToShotBool = false;
    public float counterToShot;
    public Animator animator_alien;
    public Animator actions;
    public bool deadEnemy = false;
    public GameObject explosion;
    public DeadManager DieManager;
    public GameObject particlesShot;
    
    // Use this for initialization
    void Start ()
    {
        alien1_mesh.SetActive(false);
    }

    // Update is called once per frame
    void Update ()
    {
		if(startEnemy == true)
        {
            counterToRun++;
            if(counterToRun >= 80 && counterToRun <= 85)
            {
                actions.SetBool("Run", true);
                anim_alien1.GetComponent<Animator>().enabled = true;               
            }
        }

        if(counterToShotBool)
        {
            counterToShot++;
            if (counterToShot > 20)
            {
                actions.SetBool("Reload", true);
                timeOfShot = true;

            }
            if (counterToShot > 25) actions.SetBool("Reload", false);

        }

        if(timeOfShot)
        {
            timeOfDie++;

            if (timeOfDie > 60)
            {
                DieManager.dead = true;

            }
            if (timeOfDie > 50 && DieManager.dieEnemy == false)
            {
                particlesShot.SetActive(true);
            }
        }

        if (deadEnemy)
        {
            Debug.Log("HELLO");
            explosion.SetActive(true);
            alien1_mesh.SetActive(false);
            particlesShot.SetActive(false);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "KillBomb")
        {
            deadEnemy = true;
        }
    }



}
