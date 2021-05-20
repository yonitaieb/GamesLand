using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pointsengine2 : MonoBehaviour
{
    int PointsTwo;
    // Start is called before the first frame update
    void Start()
    {
        PointsTwo = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddPointsBall()
    {
        PointsTwo++;
        GetComponent<Text>().text = "points: " + PointsTwo.ToString();
    }
    public void AddPointsOrange()
    {
        PointsTwo += 2;
        GetComponent<Text>().text = "points: " + PointsTwo.ToString();
    }
    public void AddPointsPurple()
    {
        PointsTwo += 3;
        GetComponent<Text>().text = "points: " + PointsTwo.ToString();
    }
    public void AddPointsBomB()
    {
        PointsTwo--;
        GetComponent<Text>().text = "points: " + PointsTwo.ToString();
    }
    public int AllPointsTwo()
    {
        return PointsTwo;
    }
}
