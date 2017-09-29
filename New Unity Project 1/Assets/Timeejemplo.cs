using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeejemplo : MonoBehaviour {

	
	void Start () {	
	}


    void Update()
    {
        //VARIABLE TIME: Se obtiene información de tiempo de Unity 



        //EJEMPLO 1: El tiempo en segundos que tardó en completar el último fotograma --> deltaTime
        float translation = Time.deltaTime * 10;
        transform.Translate(0, 0, translation);
    }

        //EJEMPLO  2: Número total de fotogramas que han pasado --> frameCount
        private static int lastRecalculation = -1;
         static void RecalculateValue()
    {
        if (lastRecalculation == Time.frameCount)
            return;

        //EJEMPLO 3: La escala a la que pasa el tiempo. Esto se puede utilizar para efectos de camara lenta o camara rapida -->timeScale

        if (Input.GetButtonDown("cosa"))
        {
            if (Time.timeScale == 1.0F)
                Time.timeScale = 0.7F;
            else
                Time.timeScale = 1.0F;
            Time.fixedDeltaTime = 0.02F * Time.timeScale;
        }


        //EJEMPLO 4: guarda las capturas de pantalla entre cuadros --> captureFramerate 
        Public int frameRate = 25;
        Time.captureFramerate = frameRate;

        //EJEMPLO 5:  Lectura de tiempo real en segundos desde que comenzó el juego -->  realtimeSinceStartup
        print(Time.realtimeSinceStartup);
    }
}
