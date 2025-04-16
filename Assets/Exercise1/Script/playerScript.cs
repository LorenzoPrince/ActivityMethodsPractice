using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Shot disparo;
    public Vector3 posicionInicial;
    public int speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            disparo.DispararProyectil(posicionInicial, speed);
        }
    }
}
