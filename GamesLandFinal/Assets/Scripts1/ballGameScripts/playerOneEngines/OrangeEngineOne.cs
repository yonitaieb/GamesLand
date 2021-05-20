using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OrangeEngineOne : MonoBehaviour
{
    float timeCreate;
    int ballLife;
    public int score = 0;
    PointsEngine getpoints;
    Collider2D col;
    BtnEngine Music;

    [Header("sounds")]
    public AudioSource sorce;
    public AudioClip ballPop;
    // Start is called before the first frame update
    void Start()
    {
        timeCreate = 0;
        ballLife = 0;
        col = GetComponent<Collider2D>();
        Music = GameObject.Find("Btn&SoundManager").GetComponent<BtnEngine>();
    }
    private void Awake()
    {
        getpoints = GameObject.Find("points 2").GetComponent<PointsEngine>();
        col = GetComponent<Collider2D>();

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
                    getpoints.AddPointsOrange();
                    Music.playmusic();
                }


            }
        }
    }

    private void OnMouseUpAsButton()
    {
        Destroy(gameObject);
        getpoints.AddPointsOrange();
        Music.playmusic();
    }

}

