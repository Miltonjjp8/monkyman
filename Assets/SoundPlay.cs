using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Necesario para trabajar con el UI

public class SoundPlay : MonoBehaviour
{
    AudioSource fuenteAudio;
    Button boton; // Variable para el bot�n

    void Start()
    {
        // Obt�n el componente AudioSource del objeto
        fuenteAudio = GetComponent<AudioSource>();

        // Obt�n el componente Button y asigna la funci�n de reproducci�n al evento OnClick
        boton = GetComponent<Button>();
        if (boton != null)
        {
            boton.onClick.AddListener(ReproducirSonido); // A�adimos el listener al evento OnClick del bot�n
        }
        else
        {
            Debug.LogError("El objeto no tiene un componente Button.");
        }
    }

    // M�todo que se llama cuando se hace clic en el bot�n
    void ReproducirSonido()
    {
        if (fuenteAudio != null)
        {
            fuenteAudio.Play(); // Reproducir el sonido
        }
        else
        {
            Debug.LogError("No se ha asignado un AudioSource.");
        }
    }
}
