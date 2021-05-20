using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBallPlayerOne : MonoBehaviour
{
    public GameObject ball;
    public GameObject orengeBall;
    public GameObject perpuleball;
    public GameObject bomb;
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
                createOrengeBall();
                timeCreate = Time.time;
                time--;
                timer.text = time.ToString();
            }
            else if (index == 3)
            {
                createPerouleBall();
                timeCreate = Time.time;
                time--;
                timer.text = time.ToString();
            }
            else
            {
                createBomb();
                timeCreate = Time.time;
                time--;
                timer.text = time.ToString();
            }

        }
        
        
    }
    public void createBall()
    {
        float rndx = Random.Range(-0.7f, -6.14f);
        float rndy = Random.Range(-3.83f, 3.7f);
        Instantiate(ball, new Vector2(rndx, rndy), ball.transform.localRotation);
    }
    public void createOrengeBall()
    {
        float rndx = Random.Range(-0.7f, -6.14f);
        float rndy = Random.Range(-3.83f, 3.7f);
        Instantiate(orengeBall, new Vector2(rndx, rndy), orengeBall.transform.localRotation);
    }
    public void createPerouleBall()
    {
        float rndx = Random.Range(-0.7f, -6.14f);
        float rndy = Random.Range(-3.83f, 3.7f);
        Instantiate(perpuleball, new Vector2(rndx, rndy), perpuleball.transform.localRotation);
    }
    public void createBomb()
    {
        float rndx = Random.Range(-0.7f, -6.14f);
        float rndy = Random.Range(-3.83f, 3.7f);
        Instantiate(bomb, new Vector2(rndx, rndy), bomb.transform.localRotation);
    }

}
