using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestoryEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy") || collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}
