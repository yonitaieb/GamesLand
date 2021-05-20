using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemyCar;
    public GameObject truck;
    public GameObject bike;
    float timeCreate;
    int spawnTime;
    public Text countDown;
    int counterHelp;


    int[] enemys = new int[3] { 1, 2, 3 };
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
        Instantiate(enemyCar, new Vector2(1.05f, rnd), enemyCar.transform.localRotation);
    }
    public void CreateNewBike()
    {
        float rnd = Random.Range(-4, 4.1f);
        Instantiate(bike, new Vector2(0.5f, rnd), bike.transform.localRotation);
    }
    public void CreateNewTruck()
    {
        float rnd = Random.Range(-4, 4.1f);
        Instantiate(truck, new Vector2(1.16f, rnd), truck.transform.localRotation);
    }
}
