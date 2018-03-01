using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManagement : MonoBehaviour {

    public GameSystem gameSystem;
    public Enemy1 enemy1;
    public Enemy2 enemy2;
    public Enemy3 enemy3;
    public Enemy4 enemy4;
    public Enemy5 enemy5;
    public Enemy6 enemy6;
    public Enemy7 enemy7;
    public Enemy8 enemy8;
    public Enemy9 enemy9;
    public Enemy10 enemy10;
    public Enemy11 enemy11;
    public Enemy12 enemy12;
    public Enemy13 enemy13;
    public Enemy14 enemy14;
    public Enemy15 enemy15;
    public Alien alien;
    // Use this for initialization
    void Start ()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        //FirstEnemy
        if (gameSystem.timeofGame <= 59 && enemy1.deadEnemy == false)
        {
            enemy1.startEnemy = true;
            enemy1.alien1_mesh.SetActive(true);
        }
        else enemy1.startEnemy = false;

        
        //SecondEnemy
        if (gameSystem.timeofGame <= 54 && enemy2.deadEnemy == false)
        {
            enemy2.startEnemy = true;
            enemy2.alien2_mesh.SetActive(true);

        }
        else enemy2.startEnemy = false;

        //ThirdEnemy
        if (gameSystem.timeofGame <= 54 && enemy3.deadEnemy == false)
        {
            enemy3.startEnemy = true;
            enemy3.alien3_mesh.SetActive(true);

        }
        else enemy3.startEnemy = false;

        //4-5-6 Enemy
        if (gameSystem.timeofGame <= 50 && (enemy4.deadEnemy == false) && (enemy5.deadEnemy == false) && (enemy6.deadEnemy == false))
        {
            enemy4.startEnemy = true;
            enemy4.alien4_mesh.SetActive(true);
            enemy5.startEnemy = true;
            enemy5.alien5_mesh.SetActive(true);
            enemy6.startEnemy = true;
            enemy6.alien6_mesh.SetActive(true);
        }
        else
        {
            enemy4.startEnemy = false;
            enemy5.startEnemy = false;
            enemy6.startEnemy = false;
        }

        //7-8 Enemy
        if (gameSystem.timeofGame <= 40 && (enemy7.deadEnemy == false) && (enemy8.deadEnemy == false))
        {
            enemy7.startEnemy = true;
            enemy7.alien7_mesh.SetActive(true);
            enemy8.startEnemy = true;
            enemy8.alien8_mesh.SetActive(true);
        }
        else
        {
            enemy7.startEnemy = false;
            enemy8.startEnemy = false;
        }
        
        //9 Enemy
        if (gameSystem.timeofGame <= 35 && (enemy9.deadEnemy == false))
        {
            enemy9.startEnemy = true;
            enemy9.alien9_mesh.SetActive(true);

        }
        else
        {
            enemy9.startEnemy = false;

        }

        //10 Enemy
        if (gameSystem.timeofGame <= 30 && (enemy10.deadEnemy == false))
        {
            enemy10.startEnemy = true;
            enemy10.alien10_mesh.SetActive(true);

        }
        else
        {
            enemy10.startEnemy = false;

        }

        //11 Enemy
        if (gameSystem.timeofGame <= 25 && (enemy11.deadEnemy == false))
        {
            enemy11.startEnemy = true;
            enemy11.alien11_mesh.SetActive(true);

        }
        else
        {
            enemy11.startEnemy = false;
        }

        //12 Enemy
        if (gameSystem.timeofGame <= 25 && (enemy12.deadEnemy == false))
        {
            enemy12.startEnemy = true;
            enemy12.alien12_mesh.SetActive(true);

        }
        else
        {
            enemy12.startEnemy = false;
        }

        //13 Enemy
        if (gameSystem.timeofGame <= 15 && (enemy13.deadEnemy == false))
        {
            enemy13.startEnemy = true;
            enemy13.alien13_mesh.SetActive(true);

        }
        else
        {
            enemy13.startEnemy = false;
        }
        //14 Enemy
        if (gameSystem.timeofGame <= 15 && (enemy14.deadEnemy == false))
        {
            enemy14.startEnemy = true;
            enemy14.alien14_mesh.SetActive(true);

        }
        else
        {
            enemy14.startEnemy = false;
        }

        //15 Enemy
        if (gameSystem.timeofGame <= 15 && (enemy15.deadEnemy == false))
        {
            enemy15.startEnemy = true;
            enemy15.alien15_mesh.SetActive(true);

        }
        else
        {
            enemy15.startEnemy = false;
        }
        
        //ALIEN
        if (gameSystem.timeofGame <= 10)
        {
            alien.startEnemy = true;
            alien.alien.SetActive(true);

        }
        else
        {
            alien.startEnemy = false;
        }


    }


}
