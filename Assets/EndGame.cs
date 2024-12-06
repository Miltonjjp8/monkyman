using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    AudioSource fuenteAudio;

    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        fuenteAudio.Play();
        
    }
     void OnTriggerExit(Collider other)
    {
        fuenteAudio.Stop();
    }
}
