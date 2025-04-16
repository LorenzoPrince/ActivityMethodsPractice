using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganizadorMisiones : MonoBehaviour
{
    // Start is called before the first frame update
    public Misiones misiones;
    void Start()
    {
        misiones.ActivarMision("Entregar", "Llevar la carta a el Enano de boca");

        Invoke("CompletarMision", 4f);
        Invoke("CancelarMision", 7f);
    }

    void CompletarMision()
    {
        misiones.CompletarMision("Entregar", "Llevar la carta a el Enano de boca");

    }
    void CancelarMision()
    {
        misiones.CancelarMision("Entregar", "Llevar la carta a el Enano de boca");
    }
}
