using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManagement : MonoBehaviour {

    public GameSystem gameSystem;
    public Enemy1 enemy1;
    public Enemy2 enemy2;
    public Enemy3 enemy3;

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        //FirstEnemy
        if (gameSystem.timeofGame <= 59)
        {
            enemy1.startEnemy = true;
            enemy1.alien1_mesh.SetActive(true);

        }
        else enemy1.startEnemy = false;

        //SecondEnemy
        if (gameSystem.timeofGame <= 54)
        {
            enemy2.startEnemy = true;
            enemy2.alien2_mesh.SetActive(true);

        }
        else enemy2.startEnemy = false;

        //SecondEnemy
        if (gameSystem.timeofGame <= 54)
        {
            enemy3.startEnemy = true;
            enemy3.alien3_mesh.SetActive(true);

        }
        else enemy3.startEnemy = false;
    }


}
