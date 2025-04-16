using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntajeUi : MonoBehaviour
{
    // Start is called before the first frame update
    public Puntaje puntaje;
    public int puntos = 20;
    public int bonificacion = 2;
    void Start()
    {

        puntaje.ActualizaPuntaje(puntos, bonificacion);
        int puntajeTotal = puntaje.mostrarPuntaje();
        Debug.Log(puntajeTotal);
    }

 
}
