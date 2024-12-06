using UnityEngine;
using UnityEngine.UI;

public class ControladorJuego : MonoBehaviour
{
    [SerializeField] private float tiempoMaximo;
    [SerializeField] private Slider slider;
    [SerializeField] private GameOver gameOver;
    private float tiempoActual;
    private bool tiempoActivado = false;

    private void Update()
    {
        if (tiempoActivado)
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
        else if (tiempoActual <= 0 && tiempoActivado)
        {
            Debug.Log("Derrota por tiempo");
            CambiarTemporizador(false);
            if (gameOver != null)
            {
                gameOver.GameOverFin(); // Mostrar Game Over si el tiempo termina
            }
            else
            {
                Debug.LogError("No se ha asignado el script GameOver en ControladorJuego.");
            }
        }
    }

    private void CambiarTemporizador(bool estado)
    {
        tiempoActivado = estado;
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
