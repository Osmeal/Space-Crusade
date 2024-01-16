using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CambiarTamañoImagen : MonoBehaviour
{
    public Image imagen;
    public float tiempoCrecimiento = 1.0f;
    public float tiempoDisminucion = 1.0f;
    public float escalaMaxima = 2.0f;
    public float escalaMinima = 1.0f;

    void Start()
    {
        // Inicia la animación
        StartCoroutine(AnimarImagen());
    }

    IEnumerator AnimarImagen()
    {
        while (true)
        {
            // Crecimiento
            float tiempoInicio = Time.realtimeSinceStartup;
            while (Time.realtimeSinceStartup - tiempoInicio < tiempoCrecimiento)
            {
                float progreso = (Time.realtimeSinceStartup - tiempoInicio) / tiempoCrecimiento;
                float escalaActual = Mathf.Lerp(escalaMinima, escalaMaxima, progreso);
                imagen.rectTransform.localScale = new Vector3(escalaActual, escalaActual, 1f);
                yield return null;
            }

            // Disminución
            tiempoInicio = Time.realtimeSinceStartup;
            while (Time.realtimeSinceStartup - tiempoInicio < tiempoDisminucion)
            {
                float progreso = (Time.realtimeSinceStartup - tiempoInicio) / tiempoDisminucion;
                float escalaActual = Mathf.Lerp(escalaMaxima, escalaMinima, progreso);
                imagen.rectTransform.localScale = new Vector3(escalaActual, escalaActual, 1f);
                yield return null;
            }
        }
    }
}