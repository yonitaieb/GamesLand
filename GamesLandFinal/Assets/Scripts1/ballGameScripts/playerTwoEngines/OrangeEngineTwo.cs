using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrangeEngineTwo : MonoBehaviour
{
    public GameObject ballspwan;
    float timeCreate;
    int ballLife;
    Pointsengine2 getPoints;
    Collider2D col;
    BtnEngine Music;
    // Start is called before the first frame update
    void Start()
    {
        timeCreate = 0;
        ballLife = 0;
        col = GetComponent<Collider2D>();


    }
    private void Awake()
    {
        getPoints = GameObject.Find("points 1").GetComponent<Pointsengine2>();
        col = GetComponent<Collider2D>();
        Music = GameObject.Find("Btn&SoundManager").GetComponent<BtnEngine>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeCreate > 1)
        {
            timeCreate = Time.time;
            ballLife++;
            if (ballLife == 2)
            {
                Destroy(gameObject);
                ballLife = 0;
            }
        }
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedcollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedcollider)
                {

                    Destroy(gameObject);
                    getPoints.AddPointsOrange();
                    Music.playmusic();
                }


            }
        }


    }
    void OnMouseUpAsButton()
    {
        Destroy(gameObject);
        getPoints.AddPointsOrange();
        Music.playmusic();
    }

}
