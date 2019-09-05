using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int health = 100;
    public Shootable enemy;
    public TextMeshProUGUI healthText;

    void Update()
    {
        healthText.text = health.ToString() + "Health";
        if (health <=0)
        {
            
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Enemy"))
        {
            health -= enemy.enemyDamage;
            Debug.Log("We have been hit");
        }
    }
}
