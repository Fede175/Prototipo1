using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public UI_Manager uiManagerScript;
    int score = 0;
    public int scoreMaximo;
    public float tiempoRestante = 30f;
    bool JuegoTerminado = false;
    void Awake()
    {
        Time.timeScale = 1f;
        uiManagerScript = GameObject.FindObjectOfType<UI_Manager>();
    }

    void Update()
    {
        if (JuegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (JuegoTerminado) return;

        tiempoRestante -= Time.deltaTime;
        uiManagerScript.UpdateTimer(tiempoRestante);

        if (tiempoRestante <= 0)
        {
            tiempoRestante = 0; 
            uiManagerScript.UpdateTimer(0);  
            JuegoTerminado = true; 
            uiManagerScript.MostrarPantallaGameOver();
            Time.timeScale = 0f;   
        }
    }
    
    public void RegistrarMochila()
    {
       score++;
       uiManagerScript.UpdateScore(score);
       if (score >= scoreMaximo)
        {
            JuegoTerminado = true; 
            uiManagerScript.MostrarPantallaWin();
            Time.timeScale = 0f; 
        }
    }
}
