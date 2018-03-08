using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public GameObject anim_alien1;
    public bool timeOfShot;
    public DeadManager DieManager;

    public float timeOfDie;
    public GameObject alien2_mesh;
    public bool startEnemy;
    public float counterToRun;
    public bool counterToShotBool = false;
    public float counterToShot;
    public Animator animator_alien;
    public Animator actions;
    public bool deadEnemy = false;
    public GameObject explosion;
    public GameObject particlesShot;


    // Use this for initialization
    void Start()
    {
        alien2_mesh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startEnemy == true)
        {
            counterToRun++;
            if (counterToRun >= 40 && counterToRun <= 43)
            {
                actions.SetBool("Run", true);
                anim_alien1.GetComponent<Animator>().enabled = true;

            }
        }

        if (counterToShotBool)
        {
            counterToShot++;
            if (counterToShot > 10 && counterToShot < 16)
            {
                actions.SetBool("Reload", true);
                timeOfShot = true;

            }
            if (counterToShot > 16) actions.SetBool("Reload", false);

        }

        if (timeOfShot)
        {
            timeOfDie++;

            if (timeOfDie > 52)
            {
                DieManager.dead = true;
            }
            if (timeOfDie > 47 && DieManager.dieEnemy == false)
            {
                particlesShot.SetActive(true);
            }
        }

        if (deadEnemy)
        {
            Debug.Log("HELLO");
            explosion.SetActive(true);
            alien2_mesh.SetActive(false);
            //particlesShot.SetActive(false);

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
