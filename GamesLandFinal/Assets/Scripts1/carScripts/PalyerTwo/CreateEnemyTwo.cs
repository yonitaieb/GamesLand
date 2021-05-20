using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CreateEnemyTwo : MonoBehaviour
{

    public GameObject enemyCarTwo;
    public GameObject truck2;
    public GameObject bike2;
    public Text countDown;
    float timeCreate;
    int spawnTime;
    int counterHelp;

    int[] enemys = new int [3] { 1, 2, 3 };
    int index;


    // Start is called before the first frame update
    void Start()
    {
        countDown.text = "3";
        counterHelp = 1;
        timeCreate = 0;
        spawnTime = 1;
        
        //InvokeRepeating("CreateNewEnemyCar", 1.5f, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (counterHelp == 0)
        {
            countDown.text = "3";
            timeCreate = Time.time;
            counterHelp++;
        }
        if (Time.time - timeCreate >= 2 && counterHelp == 1)
        {
            countDown.text = "2";
            timeCreate = Time.time;
            counterHelp++;
        }
        if (Time.time - timeCreate >= 1 && counterHelp == 2)
        {
            countDown.text = "1";
            timeCreate = Time.time;
            counterHelp++;
        }
        if (Time.time - timeCreate >= 1 && counterHelp == 3)
        {
            countDown.text = "";
            timeCreate = Time.time;
            counterHelp++;

        }
        if (Time.time - timeCreate >= spawnTime && counterHelp == 4)
        {
            index = Random.Range(0, enemys.Length);
            if (index == 1)
            {
                CreateNewEnemyCar();
                timeCreate = Time.time;
            }
            else if (index == 2)
            {
                CreateNewBike();
                timeCreate = Time.time;
            }
            else
            {
                CreateNewTruck();
                timeCreate = Time.time;
            }
            

        }

    }
    public void CreateNewEnemyCar()
    {
        float rnd = Random.Range(-4, 4.1f);
        Instantiate(enemyCarTwo, new Vector2(-1, rnd), enemyCarTwo.transform.localRotation);
    }
    public void CreateNewBike()
    {
        float rnd = Random.Range(-4, 4.1f);
        Instantiate(bike2, new Vector2(-0.5f, rnd), bike2.transform.localRotation);
    }
    public void CreateNewTruck()
    {
        float rnd = Random.Range(-4, 4.1f);
        Instantiate(truck2, new Vector2(-1.18f, rnd), truck2.transform.localRotation);
    }
    
}
