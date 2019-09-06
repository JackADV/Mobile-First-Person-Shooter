using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float rotSpeed = 10f;
    public Vector3 moveVelocity;
    private Rigidbody rigid;
    public float speed;
    public int health = 100;
    public Shootable enemy;
    public TextMeshProUGUI healthText;
    public MasterController movementJoystick;
    public MasterController rotationJoystick;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        healthText.text = health.ToString() + "Health";
        Vector3 moveInput = new Vector3(movementJoystick.Horizontal, 0, movementJoystick.Vertical);
        moveVelocity = moveInput.normalized * speed;
        healthText.text = health.ToString() + "HP";
        rigid.MovePosition(rigid.position + moveVelocity * Time.deltaTime);
        //this.transform.Rotate(new Vector3(0, 0, rotationJoystick.Horizontal), rotSpeed * Time.deltaTime);
        this.transform.Rotate(new Vector3(rotationJoystick.Horizontal, rotationJoystick.Horizontal, 0), rotSpeed * Time.deltaTime);
        this.transform.Rotate(new Vector3(0, rotationJoystick.Vertical, 0), rotSpeed * Time.deltaTime);
        // rotationJoystick.Horizontal
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
