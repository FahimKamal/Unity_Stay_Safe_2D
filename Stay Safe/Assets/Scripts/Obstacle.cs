using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private UnityEvent playerDead;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
        else if (col.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            EventManager.OnPlayerDeath?.Invoke();
        }
    }
}
