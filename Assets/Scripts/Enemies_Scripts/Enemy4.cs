using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4 : MonoBehaviour
{

    public GameObject alien4_mesh;
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
        alien4_mesh.SetActive(false);
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
                alien4_mesh.GetComponent<Animator>().enabled = true;

            }
        }

        if (counterToShotBool)
        {
            counterToShot++;
            if (counterToShot > 10 && counterToShot < 12) actions.SetBool("Reload", true);
            if (counterToShot > 12) actions.SetBool("Reload", false);
        }
        if (deadEnemy)
        {
            Debug.Log("HELLO");
            explosion.SetActive(true);
            explosion.transform.position = alien4_mesh.transform.position;
            alien4_mesh.SetActive(false);
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
