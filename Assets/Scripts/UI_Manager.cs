using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtTimer;

    public GameObject panelWin;
    public GameObject panelLoss;

    public void UpdateScore(int score)
    {
        txtScore.text = "Score: " + score.ToString() + "/3";
    }

    public void UpdateTimer(float time)
    {
        int tiempoEntero = (int)time;
        txtTimer.text = "Time: " + tiempoEntero.ToString();
    }

    public void MostrarPantallaWin()
    {
        panelWin.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        panelLoss.SetActive(true);
    }
}