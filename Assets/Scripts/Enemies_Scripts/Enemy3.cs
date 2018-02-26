﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{

    public GameObject alien3_mesh;
    public bool startEnemy;
    public float counterToRun;
    public bool counterToShotBool = false;
    public float counterToShot;
    public Animator animator_alien;
    public Animator actions;

    // Use this for initialization
    void Start()
    {
        alien3_mesh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startEnemy == true)
        {
            counterToRun++;
            if (counterToRun >= 4)
            {
                actions.SetBool("Run", true);
                alien3_mesh.GetComponent<Animator>().enabled = true;
                startEnemy = false;
            }
        }

        if (counterToShotBool)
        {
            counterToShot++;
            if (counterToShot > 4) actions.SetBool("Reload", true);
        }
    }



}
