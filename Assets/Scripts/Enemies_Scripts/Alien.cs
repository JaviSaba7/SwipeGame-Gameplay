﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{

    public GameObject alien;
    public bool startEnemy;
    public float counterToRun;
    public bool counterToShotBool = false;
    public float counterToShot;
    public Animator anim_total;
    public Animator anim_nave;
    public Animator anim_alien;
    public GameObject shot_alien;

    public bool deadEnemy = false;
    public GameObject explosion;
    // Use this for initialization
    void Start()
    {
        alien.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startEnemy == true)
        {
            counterToShot++;
            if (counterToShot > 100)
            {
                anim_nave.SetTrigger("Shot");
                anim_alien.SetTrigger("Shot");
                shot_alien.SetActive(true);

            }
         
        }

      

        if (deadEnemy)
        {
            Debug.Log("HELLO");
            anim_nave.SetTrigger("Die");
            explosion.SetActive(true);
            //alien.SetActive(false);
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
