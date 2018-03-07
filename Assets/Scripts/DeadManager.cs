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
    //public GameObject[] particles;
    public GameObject particles1;
    public GameObject particles2;
    public GameObject particles3;
    public GameObject particles4;
    public GameObject particles5;
    public GameObject particles6;
    public GameObject particles7;
    public GameObject particles8;
    public GameObject particles9;
    public GameObject particles10;
    public GameObject particles11;
    public GameObject particles12;
    public GameObject particles13;
    public GameObject particles14;
    public GameObject particles15;
    public TextMeshProUGUI deadText;

    public bool dieEnemy;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(dead)
        {
            Debug.Log("Dead!");
           /*explosion_player.SetActive(true);

            enemies.GetComponent<EnemyManagement>().enabled = false;
            system.timeofGame = 0;
            player.SetActive(false);*/
            //dieEnemy = true;
            //DISABLING PARTICLES
            if(dieEnemy)
            {
                particles1.SetActive(false);
                particles2.SetActive(false);
                particles3.SetActive(false);
                particles4.SetActive(false);
                particles5.SetActive(false);
                particles6.SetActive(false);
                particles7.SetActive(false);
                particles8.SetActive(false);
                particles9.SetActive(false);
                particles10.SetActive(false);
                particles11.SetActive(false);
                particles12.SetActive(false);
                particles13.SetActive(false);
                particles14.SetActive(false);
                particles15.SetActive(false);
                deadText.enabled = true;
            }
          

            /*for(int i = 0; i < 20; i++)
            {
                particles[i].SetActive(false);

            }*/

            //disable the monkey after an explosion of something like that
        }
    }
}
