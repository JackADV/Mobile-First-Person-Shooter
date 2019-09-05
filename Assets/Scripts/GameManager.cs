using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public GameObject HUD;
    public GameObject deadHUD;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        HUD.SetActive(true);
        deadHUD.SetActive(false);
    }
    void Update()
    {
        if (player.health <= 0)
        {
            
            Time.timeScale = 0.0f;
            Debug.Log("We Died");
            HUD.SetActive(false);
            deadHUD.SetActive(true);
        }
    }
}




