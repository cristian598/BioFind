using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Velocidad de movimiento
    public float changeDirectionInterval = 2f;  // Intervalo de cambio de dirección en segundos

    private Vector3 targetDirection;  // Dirección a la que se moverá la cápsula
    private float timeSinceLastChange = 0f;  // Tiempo desde el último cambio de dirección

    void Start()
    {
        // Inicializa la dirección objetivo aleatoriamente
        SetRandomDirection();
    }

    void Update()
    {
        // Actualiza el tiempo desde el último cambio de dirección
        timeSinceLastChange += Time.deltaTime;

        // Si ha pasado el intervalo, cambia la dirección
        if (timeSinceLastChange >= changeDirectionInterval)
        {
            SetRandomDirection();
            timeSinceLastChange = 0f;
        }

        // Mueve la cápsula en la dirección actual
        transform.Translate(targetDirection * moveSpeed * Time.deltaTime);
    }

    void SetRandomDirection()
    {
        // Genera una dirección aleatoria
        targetDirection = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
    }
}

