using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float _currentSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * _currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float movementSpeed)
    {
        _currentSpeed = movementSpeed;
    }
}
