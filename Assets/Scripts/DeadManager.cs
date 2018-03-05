﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadManager : MonoBehaviour {

    public GameObject player;
    public GameSystem system;
    public EnemyManagement enemies;
    public bool dead = false;
    public GameObject explosion_player;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(dead)
        {
            explosion_player.SetActive(true);
            Debug.Log("DEAD!");
            enemies.GetComponent<EnemyManagement>().enabled = false;
            system.timeofGame = 0;
            player.SetActive(false);
            //disable the monkey after an explosion of something like that
        }
	}
}