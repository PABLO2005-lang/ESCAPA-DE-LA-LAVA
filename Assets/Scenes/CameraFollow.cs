
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform jugador;
    public float suavidad = 5f;

    void LateUpdate()
    {
        if (jugador == null) return;

        Vector3 posicionObjetivo = new Vector3(
            jugador.position.x,
            jugador.position.y,
            transform.position.z
        );

        transform.position = Vector3.Lerp(
            transform.position,
            posicionObjetivo,
            suavidad * Time.deltaTime
        );
    }
}
