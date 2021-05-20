using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPoints : MonoBehaviour
{
    public TextMeshProUGUI points1;
    public TextMeshProUGUI points2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        points1.text = TotalPoints.p1.ToString();
        points2.text = TotalPoints.p2.ToString();
    }
}
