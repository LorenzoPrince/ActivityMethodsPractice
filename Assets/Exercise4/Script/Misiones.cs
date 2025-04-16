using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misiones : MonoBehaviour
{
    // Start is called before the first frame update

    private bool misionActiva = false;
    private bool misionCompletada = false;
    public void ActivarMision(string tipoMision, string objetivo)
    {
        misionActiva = true;
        misionCompletada = false;
        Debug.Log("La miision esta activada: " + tipoMision + "  el objetivo es: " + objetivo);
    }

    public void CompletarMision(string tipoMision, string objetivo)
    {
        {
            if (misionActiva == true)
            {
                misionCompletada = true;
                misionActiva = false;
                Debug.Log("La mision completada es: " + tipoMision + " el objetivo es: " + objetivo);
            }
            else
            {
                Debug.LogWarning("La mision no comenzo.");
            }
        }
    }

    public void CancelarMision(string tipoMision, string objetivo)
    {
        misionActiva = false;
        misionCompletada = false;
        Debug.Log("La mision cancelada es " + tipoMision + " El o bjetivo era: " + objetivo);
    }
}
