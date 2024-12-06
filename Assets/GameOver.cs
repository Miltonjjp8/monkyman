using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void GameOverFin()
    {
        gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None; // Liberar el cursor
        Cursor.visible = true; // Hacer visible el cursor
        Debug.Log("¡Game Over!");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
