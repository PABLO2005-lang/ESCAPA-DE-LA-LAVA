
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AjustesJugador : MonoBehaviour
{
    public int dinero = 0;
    public TMP_Text textoDinero;

    private void Start()
    {
        ActualizarDinero();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Lava"))
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex
            );
        }

        if (other.CompareTag("Moneda") ||
            other.CompareTag("Moneda 1") ||
            other.CompareTag("Moneda 2") ||
            other.CompareTag("Moneda 3"))
        {
            dinero += 1;

            ActualizarDinero();

            Destroy(other.gameObject);

            Debug.Log("¡Moneda recogida! Dinero: " + dinero + " €");
        }
    }

    private void ActualizarDinero()
    {
        if (textoDinero != null)
        {
            textoDinero.text = "Dinero: " + dinero + " €";
        }
    }
}
