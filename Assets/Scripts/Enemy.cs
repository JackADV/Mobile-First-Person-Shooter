using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public int health = 100;
    public int enemyDamage = 10, killValue = 1;
    public float speed = 10f;
    public float radius = 20f;

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

    public void TakeDamage(int bulletDamage)
    {
        health -= bulletDamage;
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Kill");
            KillCount.killCount += killValue;
        }
    }
}
