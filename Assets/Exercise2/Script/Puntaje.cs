using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    // Definir el método de actualización del puntaje: Dentro del script, crea un método público llamado ActualizarPuntaje que tome dos parámetros: puntos ganados (int puntos) y bonificación.

    // Actualizar el puntaje: Dentro del método ActualizarPuntaje, agrega los puntos y bonificaciones al puntaje actual del jugador.Debes mostrar el puntaje actual en la interfaz de usuario (o consola) a través de un método que retorne el puntaje actual.

    // Llamar al método de actualización del puntaje desde otros scripts:Desde otros scripts que gestionen eventos en el juego (como al derrotar enemigos o recolectar objetos), llama al método ActualizarPuntaje y proporciona los puntos correspondientes.


    private int puntosJugador = 0;

    public void ActualizaPuntaje(int puntos, int bonificacion)
    {
        puntosJugador += (puntos * bonificacion);
    }
    
    public int mostrarPuntaje() //int pq devuelve un entero si no devuelve nada es void
    {
        return puntosJugador;
    }
}
