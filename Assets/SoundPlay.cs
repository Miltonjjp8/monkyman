using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Necesario para trabajar con el UI

public class SoundPlay : MonoBehaviour
{
    AudioSource fuenteAudio;
    Button boton; // Variable para el botón

    void Start()
    {
        // Obtén el componente AudioSource del objeto
        fuenteAudio = GetComponent<AudioSource>();

        // Obtén el componente Button y asigna la función de reproducción al evento OnClick
        boton = GetComponent<Button>();
        if (boton != null)
        {
            boton.onClick.AddListener(ReproducirSonido); // Añadimos el listener al evento OnClick del botón
        }
        else
        {
            Debug.LogError("El objeto no tiene un componente Button.");
        }
    }

    // Método que se llama cuando se hace clic en el botón
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
