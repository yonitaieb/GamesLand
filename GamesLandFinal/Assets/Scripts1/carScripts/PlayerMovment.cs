using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovment : MonoBehaviour
{
    //Members
    float yLocation;
    [Header("movment")]
    public float speed;
    GameObject lose;
    GameObject win;
    float y;
    float x;
   


    //score
    public Text playerOnelife;
    public Text playerTwolife;
    int Life = 3;
    float timenow;

    //time


    //sounds
    [Header("sounds")]
    public AudioSource sorce;
    public AudioClip accident;


    // Start is called before the first frame update
    void Start()
    {
        lose = GameObject.Find("PanelLose");
        lose.SetActive(false);
        y = transform.position.y;
        x = transform.position.x;

        win = GameObject.Find("PanelWin");
        win.SetActive(false);

        playerOnelife.text = Life.ToString();
        playerTwolife.text = Life.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            yLocation = myclamp(transform.position.y + speed * Time.deltaTime, -4, 4);
            transform.position = new Vector2(transform.position.x, yLocation);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            yLocation = myclamp(transform.position.y - speed * Time.deltaTime, -4, 4);
            transform.position = new Vector2(transform.position.x, yLocation);
        }
    }
    float myclamp(float value, float min, float max) // = Mathf.Clamp(0, 0, 0);
    {
        if (value >= max)
        {
            return max;
        }
        else if (value <= min)
        {
            return min;
        }
        else
        {
            return value;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemy")
        {
            Life --;
            sorce.PlayOneShot(accident);
            Destroy(collision.collider.gameObject);
            if(Life == 0)
            {
                Destroy(gameObject);
                lose.SetActive(true);
            }
            
        }

    }
   
   
}
