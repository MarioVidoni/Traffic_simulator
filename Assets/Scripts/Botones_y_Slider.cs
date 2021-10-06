using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones_y_Slider : MonoBehaviour
{
    [SerializeField] Slider SpeedSlider;
    //Esto disminuye la velocidad del programa cuando se prresiona el boton lento
    public void lento() {
        Time.timeScale = 0.5f;
    }

    //Esto normlaiza la velocidad del juego a estandar cuando se presiona el boton estandar
    public void intermedio() {
        Time.timeScale = 1;
    }

    //Esto acelera la velocidad del juego cuando se presiona el boton rapido
    public void Rapido() {
        Time.timeScale = 4;
    }

    //Esto permite personalizar la velocidad del programa
    public void changeSpeed_slider() {
        Time.timeScale = SpeedSlider.value;
    }
}
