using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBallPlayerTwo : MonoBehaviour
{
    public GameObject ball;
    public GameObject orengeBalltwo;
    public GameObject pepuleBallTwo;
    public GameObject bombTwo;
    float timeCreate;
    float spawnTime;
    public Text timer;
    int time = 30;

    int[] enemys = new int[4] { 1, 2, 3, 4 };
    int index;

    // Start is called before the first frame update
    void Start()
    {
        timeCreate = 0;
        spawnTime = 1;

        


    }

    // Update is called once per frame
    void Update()
    {


        if (Time.time - timeCreate > spawnTime)
        {
            index = Random.Range(0, enemys.Length);
            if (index == 1)
            {
                createBall();
                timeCreate = Time.time;
                time--;
                timer.text = time.ToString();
            }
            else if (index == 2)
            {
                createOrengeBallTwo();
                timeCreate = Time.time;
                time--;
                timer.text = time.ToString();
            }
            else if (index == 3)
            {
                createPerpuleBallTwo();
                timeCreate = Time.time;
                time--;
                timer.text = time.ToString();
            }
            else
            {
                createbombTwo();
                timeCreate = Time.time;
                time--;
                timer.text = time.ToString();
            }
        }
    }
        public void createBall()
        {
        float rndx = Random.Range(1.9f, 7.5f);
        float rndy = Random.Range(-3.79f,3.62f);
        Instantiate(ball, new Vector2(rndx, rndy), ball.transform.localRotation);
        }
        public void createOrengeBallTwo()
        {
        float rndx = Random.Range(1.9f, 7.5f);
        float rndy = Random.Range(-3.79f, 3.62f);
        Instantiate(orengeBalltwo, new Vector2(rndx, rndy), orengeBalltwo.transform.localRotation);
        }
        public void createPerpuleBallTwo()
        {
        float rndx = Random.Range(1.9f, 7.5f);
        float rndy = Random.Range(-3.79f, 3.62f);
        Instantiate(pepuleBallTwo, new Vector2(rndx, rndy), pepuleBallTwo.transform.localRotation);
        }
        public void createbombTwo()
        {
        float rndx = Random.Range(1.9f, 7.5f);
        float rndy = Random.Range(-3.79f, 3.62f);
        Instantiate(bombTwo, new Vector2(rndx, rndy), bombTwo.transform.localRotation);
        }

}
