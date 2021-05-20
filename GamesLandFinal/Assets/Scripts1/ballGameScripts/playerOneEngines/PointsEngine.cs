using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsEngine : MonoBehaviour
{
    int PointsOne;
    // Start is called before the first frame update
    void Start()
    {
        PointsOne = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPointsBall()
    {
        PointsOne++;
        GetComponent<Text>().text = "points: " + PointsOne.ToString();
    }
    public void AddPointsOrange()
    {
        PointsOne += 2;
        GetComponent<Text>().text = "points: " + PointsOne.ToString();
    }
    public void AddPointsPurple()
    {
        PointsOne += 3;
        GetComponent<Text>().text = "points: " + PointsOne.ToString();
    }
    public void AddPointsBomB()
    {
        PointsOne --;
        GetComponent<Text>().text = "points: " + PointsOne.ToString();
    }
    public int AllPointsOne()
    {
        return PointsOne;
    }
}
