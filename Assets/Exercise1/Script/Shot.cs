using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // Start is called before the first frame update
    // 1 Crear un objeto para el proyectil: Crea un objeto GameObject (puede ser una esfera, un cubo, etc.) que servirá como proyectil en tu juego. Agrega un componente Rigidbody al objeto proyectil para que tenga física.
    // 2 Crear un script para el control del disparo: Crea un nuevo script en C# y asígnalo a un GameObject en tu escena. Abre el script en tu editor de código preferido.
    // 3 Definir el método de disparo: Dentro del script, crea un método público llamado DispararProyectil  que tome dos parámetros: la posición inicial del disparo (Vector3 posicion) y la velocidad del proyectil (float velocidad).
    // 4 Instanciar el proyectil:Dentro del método DispararProyectil, utiliza Instantiate para crear una instancia del proyectil en la posición especificada. Asigna la velocidad al componente Rigidbody del proyectil para que se mueva con la velocidad especificada.
    // 5 Llamar al método de disparo desde otro script: En otro script o en el controlador del jugador, llama al método DispararProyectil y proporciona la posición desde donde se realizará el disparo y la velocidad del proyectil.

    public GameObject Bullet;
    public void DispararProyectil(Vector3 posicion, float velocidad)
    {
        GameObject proyectil = Instantiate(Bullet, posicion, Quaternion.identity); // sin rotacion es el quaternion.identity
        //importante que sea una variable para poder hacer que se mueva.
        Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>(); //encuentro el rigi
        rb.velocity = transform.right * velocidad;
    }
}
