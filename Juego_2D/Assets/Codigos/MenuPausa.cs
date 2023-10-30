using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    
    
    //Panel oculto
    public GameObject menuPausa; 
    
    //Variable que nos dive si el juego esta pausado o no
    public bool juegoPausado = false; 
    
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Activasión por medio del teclado
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Condición que revisa si el juego está o no en pausa
            if (juegoPausado)
            {
                //juego activo
                Debug.Log("El juego está activo");
                ContinuarJuego();
            }
            else
            {

                //juego pausado
                Debug.Log("El juego esta pausado");
                PausaJuego();
            }
        }

    }


    //Funsión de pausa
    public void PausaJuego()
	{
        juegoPausado = true;
        Time.timeScale = 0; //Pausar el tiempo del juego
        menuPausa.SetActive(true);
	}

    //Funsión de continuar 

    public void ContinuarJuego() 
    {
        juegoPausado = false;
        Time.timeScale = 1;
        menuPausa.SetActive(false);
    }


    public void SalirdelJuego() 
    {
        Application.Quit(); //Salir del juego (Solo en compilaciones)
    }


}
