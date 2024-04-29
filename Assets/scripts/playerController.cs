using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 10.0f;                   
    public float initialForwardSpeed = 5.0f;     
    public float forwardSpeed = 7.5f;            
    public float backwardSpeed = 2.5f;           
    public float decelerationFactor = 3.5f;      
    public float lateralMovementBoundary = 5.0f; // La limite de déplacement latéral pour empêcher le bateau de sortir de l'écran

    private float currentLateralSpeed = 0f;
    private float currentForwardSpeed;
    public GameObject Panel;

    void Start()
    {
        currentForwardSpeed = 0f;
        currentLateralSpeed = 0f;
    }

    void Update()
    {
        HandleMovement();
    }

void HandleMovement()
{
    float horizontalInput = Input.GetAxis("Horizontal");
    currentLateralSpeed = horizontalInput != 0 ? horizontalInput * speed : 0;
    Vector3 movement = new Vector3(currentLateralSpeed, 0, currentForwardSpeed) * Time.deltaTime;
    transform.Translate(movement, Space.World);
}

    public void StartMoving()
    {
        currentForwardSpeed = initialForwardSpeed;
    Debug.Log("Le bateau commence à bouger à la vitesse de " + currentForwardSpeed);
    }
}
