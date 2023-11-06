using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interaccion : MonoBehaviour
{
    public UnityEvent entro;
    public UnityEvent salio;

    [SerializeField] private GameObject efecto;
    [SerializeField] private float cantidadPuntos; // Cambiado a un valor int en lugar de GameObject
    [SerializeField] private Puntaje Puntaje; // Agrega una referencia al componente Puntaje

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            entro.Invoke();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            salio.Invoke();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            entro.Invoke();
            Puntaje.SumarPuntos(cantidadPuntos); // Llama al método SumarPuntos con la cantidad de puntos
            Instantiate(efecto, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            salio.Invoke();
        }
    }
}

