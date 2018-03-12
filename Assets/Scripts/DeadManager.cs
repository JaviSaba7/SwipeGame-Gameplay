using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DeadManager : MonoBehaviour {

    public GameObject player;
    public GameSystem system;
    public EnemyManagement enemies;
    public bool dead = false;
    public GameObject explosion_player;
    public GameObject particles;
    public Button restart;
    public TextMeshProUGUI deadText;

    public bool dieEnemy;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (dead)
        {
            Debug.Log("Dead!");
            explosion_player.SetActive(true);
           
            enemies.GetComponent<EnemyManagement>().enabled = false;
            system.timeofGame = 0;
            player.SetActive(false);
            dieEnemy = true;

            //DISABLING PARTICLES
            if (dieEnemy)
            {

                deadText.enabled = true;
            }


            restart.enabled = true;
            particles.SetActive(false);

           

            //disable the monkey after an explosion of something like that
        }
    }
}
