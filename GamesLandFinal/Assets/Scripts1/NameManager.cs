using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    [Header("PlayerNames")]
    public Text player1name;
    public Text player2name;

    
    
    // Start is called before the first frame update
    void Start()
    {
        player1name.text = InputEngine.p1;
        player2name.text = InputEngine.p2;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
