using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    public GameObject alien1_mesh;
    public bool startEnemy;
    public float counterToRun;
    public bool counterToShotBool = false;
    public float counterToShot;
    public Animator animator_alien;
    public Animator actions;
    public GameObject particles;

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
            if(counterToRun >= 20 && counterToRun <= 23)
            {
                actions.SetBool("Run", true);
                alien1_mesh.GetComponent<Animator>().enabled = true;
                
            }
        }

        if(counterToShotBool)
        {
            counterToShot++;
            if(counterToShot > 4) actions.SetBool("Reload", true);
        }

       
    }
        void OnTriggerEnter(Collider other)
        {
            if (gameObject.tag == "KillBomb")
            {
                Debug.Log("COLLISION!!!!!");
                particles.SetActive(true);

            }



        }


}
