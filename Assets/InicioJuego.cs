using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class InicioJuego : MonoBehaviour
{
    public Text contadorRegresivo; // Referencia al componente de texto para mostrar el contador regresivo

    private void Start()
    {
        StartCoroutine(ContadorRegresivo());

    }

    IEnumerator ContadorRegresivo()
    {
        int cuenta = 3;
        while (cuenta > 0)
        {
            contadorRegresivo.text = cuenta.ToString();
            yield return new WaitForSeconds(1);
            cuenta--;
        }

        contadorRegresivo.text = "¡Comienza el juego!";
        // Aquí puedes iniciar tu juego
    }

}
