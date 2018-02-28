using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    // Use this for initialization
    public GameObject particles;
    public GameObject alien;

    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "KillBomb")
        {
            Debug.Log("HELLO");
            particles.SetActive(true);
            alien.SetActive(false);
        }

    }
}
