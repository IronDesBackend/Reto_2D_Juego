using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public string cambioEscena;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //Estoy comparando si la colisión es un un objeto que se llama player
        {

            SceneManager.LoadScene(cambioEscena);

            Debug.Log("ESTOY LISTO PARA CAMBIAR DE ESCENA PAPÁ");


        }
    }



}
