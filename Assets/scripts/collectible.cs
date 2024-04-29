using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    public scoreManager scoreManagerScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boat"))
        {
            FindObjectOfType<scoreManager>().AddCoin();
            gameObject.SetActive(false);
        }
    }
}
