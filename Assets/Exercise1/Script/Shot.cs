using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // Start is called before the first frame update
    // 1 Crear un objeto para el proyectil: Crea un objeto GameObject (puede ser una esfera, un cubo, etc.) que servir� como proyectil en tu juego. Agrega un componente Rigidbody al objeto proyectil para que tenga f�sica.
    // 2 Crear un script para el control del disparo: Crea un nuevo script en C# y as�gnalo a un GameObject en tu escena. Abre el script en tu editor de c�digo preferido.
    // 3 Definir el m�todo de disparo: Dentro del script, crea un m�todo p�blico llamado DispararProyectil  que tome dos par�metros: la posici�n inicial del disparo (Vector3 posicion) y la velocidad del proyectil (float velocidad).
    // 4 Instanciar el proyectil:Dentro del m�todo DispararProyectil, utiliza Instantiate para crear una instancia del proyectil en la posici�n especificada. Asigna la velocidad al componente Rigidbody del proyectil para que se mueva con la velocidad especificada.
    // 5 Llamar al m�todo de disparo desde otro script: En otro script o en el controlador del jugador, llama al m�todo DispararProyectil y proporciona la posici�n desde donde se realizar� el disparo y la velocidad del proyectil.

    public GameObject Bullet;
    public void DispararProyectil(Vector3 posicion, float velocidad)
    {
        GameObject proyectil = Instantiate(Bullet, posicion, Quaternion.identity); // sin rotacion es el quaternion.identity
        //importante que sea una variable para poder hacer que se mueva.
        Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>(); //encuentro el rigi
        rb.velocity = transform.right * velocidad;
    }
}
