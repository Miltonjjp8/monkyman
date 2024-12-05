using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJuego : MonoBehaviour
{
    [SerializeField] private float tiempoMaximo;
    [SerializeField] private Slider slider;
    private float tiempoActual;
    private bool timepoActivado = false;

    private void Update()
    {
        if (timepoActivado)
        {
            CambiarContador();
        }
    }

    private void CambiarContador()
    {
        

        
        tiempoActual -= Time.deltaTime;
        if (tiempoActual >= 0)
        {
            slider.value = tiempoActual;
        }


            if (tiempoActual <= 0)
        {
            Debug.Log("Derrota");
            CambiarTemporizador(false);
        }
    }

    private void CambiarTemporizador(bool estado)
    {
        timepoActivado = estado;
    }

    public void ActivarTemporizador()
    {
        tiempoActual = tiempoMaximo;
        slider.maxValue = tiempoMaximo;
        CambiarTemporizador(true);
    }

    public void DesactivarTemporizador()
    {
        CambiarTemporizador(false);
    }

}
