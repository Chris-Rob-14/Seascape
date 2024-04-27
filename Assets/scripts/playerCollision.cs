using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public LifeManager lifeManager; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle") // Assurez-vous que vos obstacles ont le tag "Obstacle"
        {
            lifeManager.LoseLife();
            Destroy(other.gameObject); // Détruire l'obstacle, ou le désactiver selon le besoin
        }
    }
}
