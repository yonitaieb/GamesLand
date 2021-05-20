using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AudioPreservation : MonoBehaviour
{
    GameObject p;
    private AudioSource _audioSource;
    Scene s;
    static GameObject me;
    void Awake()
    {
        Scene s = SceneManager.GetActiveScene();
       
        if(me == null)
        {
            me = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
      




        _audioSource = GetComponent<AudioSource>();
        p = GameObject.Find("Audiosource");
    }

    // Update is called once per frame
    void Update()
    {
        Scene s = SceneManager.GetActiveScene();

        if (s.name == "Game" || s.name == "MainMenu")
        {
            DontDestroyOnLoad(gameObject);

        }
        else
            Destroy(gameObject);
    }
}
