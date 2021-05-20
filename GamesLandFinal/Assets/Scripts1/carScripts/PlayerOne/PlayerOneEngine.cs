using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneEngine : MonoBehaviour
{
    //touch
    Vector2 touchPosition;
    private Vector3 direction;

    [Header("PlayerNames")]
    public Text playertwoname;
    public Text playeronename;
    public Text playerTwoScore;
    public Text playerOneScore;
    public Text winPanelHeader;

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
    int Life = 3;


    //time

    //gameobject
    public GameObject PlayerTwoWin;
    public GameObject header;
    public GameObject carTwo;

    //sounds
    [Header("sounds")]
    public AudioSource source;
    public AudioClip accident;

    
    string player2name;
    string player1name;


    // Start is called before the first frame update
    void Start()
    {
       

        playerOnelife.text = Life.ToString();

        PlayerTwoWin.SetActive(false);
        header.SetActive(true);

        player2name = InputEngine.p2;
        player1name = InputEngine.p1;
        playeronename.text = InputEngine.p1;
        playertwoname.text = InputEngine.p2;
        winPanelHeader.text = InputEngine.p2 + " is the winner";
    }

    // Update is called once per frame
    void Update()
    {
        //touch
        for (int i = 0; i < Input.touchCount; i++)
        {

            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            if (touchPosition.x > 1.55f)
            {


                transform.position = new Vector2(transform.position.x, touchPosition.y);
            }
        }
        //arrows
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
        if (Life == 1)
        {
            Destroy(gameObject);
            PlayerTwoWin.SetActive(true);
            playerTwoScore.text = player2name;
            playerOneScore.text = player1name;
            header.SetActive(false);
            Destroy(carTwo);
        }

        if (collision.collider.tag == "enemy")
        {
            Life--;
            playerOnelife.text = Life.ToString();
            source.PlayOneShot(accident);
            Destroy(collision.collider.gameObject);
           
        }


    }

}
