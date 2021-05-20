using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputEngine : MonoBehaviour
{
  
   public static string p1;
   public static string p2;
    GameObject inp1;
    GameObject inp2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inp1 = GameObject.Find("InputP1");
        inp2 = GameObject.Find("InputP2");
        GameObject.Find("PlayerOne").GetComponent<TextMeshProUGUI>().text = p1;
        GameObject.Find("PlayerTWO").GetComponent<TextMeshProUGUI>().text = p2;
        if(p1 != null)
        {
            Destroy(inp1);
        }
        if (p2 != null)
        {
            Destroy(inp2);
        }
    }
    public  void ReadInput(string n1)
    {
        p1 = n1;
        
        
        Destroy(inp1);
    }
    public void ReadInput2(string n2)
    {
        p2 = n2;
        Destroy(inp2);
    }
}
