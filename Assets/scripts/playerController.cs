using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 5.0f;           // Vitesse de déplacement latéral du bateau
    public float decelerationFactor = 0.5f; // Facteur de ralentissement lorsque la flèche bas est pressée
    public float lateralMovementBoundary = 5.0f; // La limite de déplacement latéral pour empêcher le bateau de sortir de l'écran

    private float currentSpeed;

    void Update()
    {
        HandleMovement();
    }

void HandleMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Obtenir l'input des flèches gauche et droite

        // Déplacer le bateau latéralement en fonction des inputs
        Vector3 newPosition = transform.position + new Vector3(horizontalInput * currentSpeed * Time.deltaTime, 0, 0);
        newPosition.x = Mathf.Clamp(newPosition.x, -lateralMovementBoundary, lateralMovementBoundary);
        transform.position = newPosition;

        // Gérer la décélération si la flèche bas est pressée
        if (Input.GetKey(KeyCode.DownArrow))
        {
            currentSpeed = speed * decelerationFactor;
        }
        else
        {
            currentSpeed = speed;
        }
    }
}