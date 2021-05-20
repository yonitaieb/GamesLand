using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BtnEngine : MonoBehaviour
{
    
    public GameObject Dev;
    public AudioClip click;
    public AudioClip pop;
    public AudioSource source;
    public void GotoGame()
    {
        SceneManager.LoadScene("Game");
        source.PlayOneShot(click);

    }

    public void Openpanel()
    {
        Dev.SetActive(true);
        source.PlayOneShot(click);
    }
    public void Closepanel()
    {
        Dev.SetActive(false);
        source.PlayOneShot(click);
    }
    public void GobacktoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        source.PlayOneShot(click);
    }
    public void StartCrazyCars()
    {
        SceneManager.LoadScene("cargame");
        source.PlayOneShot(click);
    }
    public void StartCTT()
    {
        SceneManager.LoadScene("ballGame");
        source.PlayOneShot(click);
    }
    public void carGameManual()
    {
        SceneManager.LoadScene("CarGame Manual");
        source.PlayOneShot(click);
    }
    public void BallGameManual()
    {
        SceneManager.LoadScene("Ball Game Manual");
        source.PlayOneShot(click);
    }
    public void playmusic()
    {
       source.PlayOneShot(pop);
    }
}



