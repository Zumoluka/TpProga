using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameStart : MonoBehaviour
{

    public TextMeshProUGUI contadorText;
    public int tiempoInicial = 3;

    void Start()
    {
        // Comienza el contador regresivo.
        StartCoroutine(ContadorRegresivoCorrutina());
    }

    IEnumerator ContadorRegresivoCorrutina()
    {
        int tiempoActual = tiempoInicial;

        // Pausa el juego al inicio del contador.
        Time.timeScale = 0f;

        while (tiempoActual > 0)
        {
            // Actualiza el texto del contador en la UI.
            contadorText.text = tiempoActual.ToString();

            // Espera un segundo en tiempo real antes de actualizar el contador.
            yield return new WaitForSecondsRealtime(1f);

            tiempoActual--;
        }

        // Cuando el contador llega a cero, muestra un mensaje o realiza acciones adicionales.
        contadorText.text = "¡Comienza el juego!";
        // Agrega aquí la lógica para iniciar el juego.

        // Restaura la velocidad del tiempo a 1 para reanudar el juego.
        Time.timeScale = 1f;
    }
}


