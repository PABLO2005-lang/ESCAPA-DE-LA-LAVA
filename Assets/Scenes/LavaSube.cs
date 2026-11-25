
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaSube : MonoBehaviour
{
    public float velocidadSubida = 0.5f;

    void Update()
    {
        // La lava sube poco a poco
        transform.position += Vector3.up * velocidadSubida * Time.deltaTime;
    }

    // Detectar cuando toca al jugador
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Reiniciar el nivel
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex
            );
        }
    }
}
