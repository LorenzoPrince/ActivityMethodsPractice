using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    // Definir el m�todo de actualizaci�n del puntaje: Dentro del script, crea un m�todo p�blico llamado ActualizarPuntaje que tome dos par�metros: puntos ganados (int puntos) y bonificaci�n.

    // Actualizar el puntaje: Dentro del m�todo ActualizarPuntaje, agrega los puntos y bonificaciones al puntaje actual del jugador.Debes mostrar el puntaje actual en la interfaz de usuario (o consola) a trav�s de un m�todo que retorne el puntaje actual.

    // Llamar al m�todo de actualizaci�n del puntaje desde otros scripts:Desde otros scripts que gestionen eventos en el juego (como al derrotar enemigos o recolectar objetos), llama al m�todo ActualizarPuntaje y proporciona los puntos correspondientes.


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
