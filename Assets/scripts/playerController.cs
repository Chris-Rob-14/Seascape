using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 5.0f;                   // Vitesse de déplacement latéral du bateau
    public float initialForwardSpeed = 4.0f;     // Vitesse de démarrage vers l'avant du bateau
    public float forwardSpeed = 7.5f;            // Vitesse maximale de déplacement vers l'avant
    public float backwardSpeed = 2.5f;           // Vitesse de déplacement vers l'arrière (plus lente)
    public float decelerationFactor = 0.5f;      // Facteur de ralentissement lorsque la flèche bas est pressée
    public float lateralMovementBoundary = 5.0f; // La limite de déplacement latéral pour empêcher le bateau de sortir de l'écran

    private float currentLateralSpeed = 0f;
    private float currentForwardSpeed;
    public GameObject Panel;

    void Start()
    {
         // Initialisez la vitesse vers l'avant à 0 pour éviter que le bateau ne bouge au début
        currentForwardSpeed = 0f;
        // Assurez-vous de ne pas bouger latéralement non plus
        currentLateralSpeed = 0f;
    }

    void Update()
    {
        HandleMovement();
    }

void HandleMovement()
{
    // Gérer le mouvement latéral basé sur l'input utilisateur
    float horizontalInput = Input.GetAxis("Horizontal");
    currentLateralSpeed = horizontalInput != 0 ? horizontalInput * speed : 0;

    // Appliquer le mouvement latéral et aussi la vitesse vers l'avant constante
    Vector3 movement = new Vector3(currentLateralSpeed, 0, currentForwardSpeed) * Time.deltaTime;
    transform.Translate(movement, Space.World);
}

    public void StartMoving()
    {
        currentForwardSpeed = initialForwardSpeed;
    Debug.Log("Le bateau commence à bouger à la vitesse de " + currentForwardSpeed);
    }
}
