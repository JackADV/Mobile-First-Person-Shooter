using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class KillCount : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static int killCount;

    public void Start()
    {
        killCount = 0;
    }
    public void Update()
    {
        text.text = "Kills: " + killCount;
    }
    public void Win()
    {
        if (killCount >= 10)
        {
            Debug.Log("We win");
        }
    }
}
