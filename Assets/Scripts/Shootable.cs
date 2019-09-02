using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootable : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            ItemBreak();
        }
    }

    void ItemBreak()
    {
        Destroy(gameObject);
    }

}
