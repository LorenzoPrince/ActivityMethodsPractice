using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventary : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> Items;
    public GameObject linterna;
    public GameObject cura;
    public GameObject pistola;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void agregarObjeto(GameObject objeto, int cantidad)
    {

        {
            for (int i = 0; i < cantidad; i++)
            {
                Items.Add(objeto);
            }
        }
    }
    public void quitarObjeto(GameObject objeto, int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        { 
            Items.Remove(objeto); 
        }

    }
}
