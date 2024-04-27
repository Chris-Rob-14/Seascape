using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBooster : MonoBehaviour
{
     public float accelerationInterval = 10.0f;
    private float accelerationTimer = 0;
    public float speedIncrease = 1.0f;
    public playerController playerController;

    void Update()
    {
        accelerationTimer += Time.deltaTime;
        if (accelerationTimer > accelerationInterval)
        {
            playerController.speed += speedIncrease;
            accelerationTimer = 0;
        }
    }
}
