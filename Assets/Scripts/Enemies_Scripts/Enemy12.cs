﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy12 : MonoBehaviour
{
    public GameObject anim_alien1;
    public bool timeOfShot;
    public DeadManager DieManager;

    public float timeOfDie;
    public GameObject alien12_mesh;
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
        alien12_mesh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startEnemy == true)
        {
            counterToRun++;
            if (counterToRun >= 20 && counterToRun <= 23)
            {
                actions.SetBool("Run", true);
                anim_alien1.GetComponent<Animator>().enabled = true;

            }
        }

        if (counterToShotBool)
        {
            counterToShot++;
            if (counterToShot > 10 && counterToShot < 12)
            {
                actions.SetBool("Reload", true);
                timeOfShot = true;

            }
            if (counterToShot > 12) actions.SetBool("Reload", false);
        }
        if (deadEnemy)
        {
            Debug.Log("HELLO");
            explosion.SetActive(true);
            explosion.transform.position = alien12_mesh.transform.position;
            alien12_mesh.SetActive(false);
        }

        if (timeOfShot)
        {
            timeOfDie++;
            if (timeOfDie > 20)
            {
                DieManager.dead = true;
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