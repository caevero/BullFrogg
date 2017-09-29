using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_ejemplos : MonoBehaviour {

    // Use this for initialization
    void Start() {
    }

    //VARIABLE INPUT: Sirve como sistema de entrada en los videojuegos, como dices vos: si un videojuego no tiene esto, es una pelicula. Ejemplo: presionar un boton, el mouse, mando, etc.


    //EJEMPLO 1:informa de la posición del ratón --> Input.mousePosition
       public GameObject elemento;
        void Update()
    {
        if (Input.GetButtonDown("Objetico"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
                Instantiate(elemento, transform.position, transform.rotation);
        }

        //EJEMPLO2: Cada entrada representa el estado de un dedo tocando la pantalla. --> Touch

        int toques = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
               toques++;
        }

        if (toques > 0)
            print("El usuario tiene " + toques + " toques en la pantalla");

        //EJEMPLO 3  Devuelve si se mantiene pulsado el botón del ratón. --> GetMouseButton
        //El valor del botón izquierdo es 0, 1 para el botón derecho, 2 para el botón central.

        if (Input.GetMouseButton(0))
            Debug.Log("Presionaste click derecho.");

        if (Input.GetMouseButton(1))
            Debug.Log("Presionaste click izquierdo.");

        if (Input.GetMouseButton(2))
            Debug.Log("Presionaste click medio.");


        //EJEMPLO 4 Devuelve la medición de la aceleración específica que se produjo durante el último frame --> GetAccelerationEvent
        Vector3 aceleracion = Vector3.zero;
        int i = 0;
        while (i < Input.accelerationEventCount) {
            AccelerationEvent accEvent = Input.GetAccelerationEvent(i);
            aceleracion += accEvent.acceleration * accEvent.deltaTime;
            ++i;
        }
        print(aceleracion);


        //EJEMPLO 5 Detectar un click o prcuando presiona un botono--> AnyKey
        if (Input.anyKey)
            Debug.Log("Se ha detectado un click");
    }


}







