using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhosTheWinner : MonoBehaviour
{
    [Header("PlayerNames")]
    public Text playeronename;
    public Text playertwoname;

    //scripts
    PointsEngine playerOne;
    Pointsengine2 playerTwo;
    //score
    int scoreOne;
    int scoreTwo;
    //time
    public int time = 30;
    float timeCreate;
    //game panels
    public GameObject winnerOne;
    public GameObject winnertwo;
    public GameObject tie;
    //score text
    public Text playerOneScoreOne;
    public Text playerTwoScoreOne;
    public Text playerOneScoreTwo;
    public Text playerTwoScoreTWo;
    public Text playerTwoTie;
    public Text playerOneTie;
    string player1name;
    string player2name;
    //if winner is p1 true else false
    bool winner;

    // Start is called before the first frame update
    void Start()
    {
        playerOne = GameObject.Find("points 2").GetComponent<PointsEngine>();
        playerTwo = GameObject.Find("points 1").GetComponent<Pointsengine2>();
        winnerOne.SetActive(false);
        winnertwo.SetActive(false);
        tie.SetActive(false);
        player1name = InputEngine.p1;
        player2name = InputEngine.p2;
        playeronename.text = InputEngine.p1;
        playertwoname.text = InputEngine.p2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeCreate > 1)
        {
            timeCreate = Time.time;
            time--;
        }


        scoreOne = playerOne.AllPointsOne();
        scoreTwo = playerTwo.AllPointsTwo();
        if (scoreOne > scoreTwo && time < 0)
        {
            winnerOne.SetActive(true);
            playerOneScoreOne.text = player1name + "'s" + " score :" + scoreOne.ToString();
            playerTwoScoreOne.text = player2name + "'s" + " score :" + scoreTwo.ToString();
            winnerOne.GetComponentInChildren<Text>().text = "the winner is " + player1name;

        }
        else if (scoreTwo > scoreOne && time < 0)
        {
            winnertwo.SetActive(true);
            playerTwoScoreTWo.text = player1name + "'s" + " score :" + scoreOne.ToString();
            playerOneScoreTwo.text = player2name + "'s" + " score :" + scoreTwo.ToString();
            winnertwo.GetComponentInChildren<Text>().text = "the winner is " + player2name;
        }
        else if (scoreOne == scoreTwo && time < 0)
        {
            tie.SetActive(true);
            playerTwoTie.text = player1name + "'s" + " score :" + scoreOne.ToString();
            playerOneTie.text = player2name + "'s" + " score :" + scoreTwo.ToString();
        }

    }
    public void pointsto1()
    {
        TotalPoints.p1++;
    }
    public void pointsto2()
    {
        TotalPoints.p2++;
    }
}