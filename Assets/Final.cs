using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    [SerializeField] private ControladorJuego controladorJuego;
    public GameOver gameOver;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controladorJuego.DesactivarTemporizador();
            FinJuego();
        }
    }

    public void FinJuego()
    {
        gameOver.GameOverFin();
    }
}
