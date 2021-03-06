﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy8 : MonoBehaviour
{
    public GameObject anim_alien1;
    public bool timeOfShot;
    public DeadManager DieManager;
    public GameObject particlesShot;
    public float timeOfDie;
    public GameObject alien8_mesh;
    public bool startEnemy;
    public float counterToRun;
    public bool counterToShotBool = false;
    public float counterToShot;
    public Animator animator_alien;
    public Animator actions;
    public bool deadEnemy = false;
    public GameObject explosion;
    // Use this for initialization
    void Start()
    {
        alien8_mesh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startEnemy == true)
        {
            counterToRun++;
            if (counterToRun >= 150 && counterToRun <= 180)
            {
                actions.SetBool("Run", true);
                anim_alien1.GetComponent<Animator>().enabled = true;

            }
        }

        if (counterToShotBool)
        {
            counterToShot++;
            if (counterToShot > 20)
            {
                actions.SetBool("Reload", true);
                timeOfShot = true;

            }
            if (counterToShot > 100) actions.SetBool("Reload", false);

        }

        if (deadEnemy)
        {
            particlesShot.SetActive(false);
            anim_alien1.GetComponent<Animator>().enabled = false;

            explosion.SetActive(true);
            explosion.transform.position = alien8_mesh.transform.position;
            alien8_mesh.SetActive(false);

        }


        if (timeOfShot)
        {
            timeOfDie++;

            if (timeOfDie > 220)
            {
                DieManager.dead = true;

            }
            if (timeOfDie > 200 && DieManager.dieEnemy == false)
            {
                particlesShot.SetActive(true);
            }
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
