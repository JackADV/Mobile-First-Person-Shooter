using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootable : MonoBehaviour
{
    public float health = 50f;
    public int killValue = 1;
    public Transform target;
    public int enemyDamage = 10;
    public float speed = 10f;
    public float radius = 20f;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            ItemBreak();
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Kill");
            KillCount.killCount += killValue;
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            health -= enemyDamage;
            Debug.Log("We have hit the player");
        }
    }
    void ItemBreak()
    {
        Destroy(gameObject);
    }
    

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) < radius)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
    public void Win()
    {
        if (killValue >= 10)
        {
            Debug.Log("We Win");
        }
    }

    //public void TakeDamage(float amount)
    //{
    //    health -= amount;
    //    if (health <= 0)
    //    {
    //        Destroy(gameObject);
    //        Debug.Log("Kill");
    //        KillCount.killCount += killValue;
    //    }
    //}
}
