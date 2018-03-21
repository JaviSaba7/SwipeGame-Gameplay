using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using TMPro;

public class GameSystem : MonoBehaviour {
  
    public float timeToStart = 3.0f;
    public float timeofGame = 60.0f;
    public Text counterToStartText;
    public Text gameTimeText;
    public bool startGame;
    public bool startToPlay;
    public GameObject reset;
    public EnemyManagement enemies;
    public float counter;
    public bool turnOff = false;
    public GameObject dead;

    // Use this for initialization
    void Start ()
    {
        startGame = true;
    }

    // Update is called once per frame
    void Update ()
    {

        if (turnOff) counter++;
        if (counter > 60)
        {
            counter = 0;
            turnOff = false;
        }

        if (startGame)
        {
            counterToStartText.text = timeToStart.ToString("0");
            timeToStart -= Time.deltaTime;
        }

        if(timeToStart < 0)
        {
            counterToStartText.enabled = false;
            gameTimeText.enabled = true;
            startToPlay = true;
            timeToStart = 3;
            startGame = false;
        }

        if(startToPlay)
        {
            gameTimeText.text = timeofGame.ToString("0");
            timeofGame -= Time.deltaTime;
            
        }

        if (timeofGame < 0.0f)
        {
            Debug.Log("YOU ARE DEATH");
            dead.GetComponent<TextMeshProUGUI>().enabled = true;
            timeofGame = 0.0f;
            reset.SetActive(true);
            //characters.SetActive(false);

        }


    }
}
    
