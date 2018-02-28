using System.Collections;
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
            counterToRun++;
            if (counterToRun >= 20 && counterToRun <= 23)
            {
                alien.GetComponent<Animator>().enabled = true;

            }
        }

        if (counterToShotBool)
        {
            counterToShot++;
            if (counterToShot > 5)
            {
                anim_nave.SetTrigger("Shot");
                anim_alien.SetTrigger("Shot");
            }
        }
    }



}
