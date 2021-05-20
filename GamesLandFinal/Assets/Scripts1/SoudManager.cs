using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoudManager : MonoBehaviour
{
    [Header("Audio source")]
    public AudioSource Source;
    public AudioClip Music;
    
    void Start()
    {
        Source.PlayOneShot(Music);
    }

   
    void Update()
    {
        
    }
}
