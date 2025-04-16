using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bullet;
    void Start()
    {

    }

    // Update is called once per frame

    public void DispararProyectil(Vector3 posicion, float velocidad)
    {
        Instantiate(Bullet, posicion, Quaternion.identity); // sin rotacion es el quaternion.identity
    }
}
