using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int damage = 1; // Weapon damage

    public float fireRate = 1.0f; // How often the player can fire
    public float weaponRange = 50f; // Distance in units which the player can fire
    public float hitForce = 100f; // Amount of force which will be added to a rigidbody shot by the player
    public Transform gunEnd; // Holds a reference to the gun end object marking the muzzle location of the gun

    private Camera fpsCam; // Reference to the first person camera
    private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);
    // WaitForSeconds used by the ShotEffect coroutine, determines time laser line will remain visable
    private LineRenderer line; // Reference to the LineRenderer component which will displa the laser
    private float nextFire; // Float to store the time the player will be allowed to fire again, after firing

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();

        fpsCam = GetComponentInParent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            StartCoroutine (ShotEffect());
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
            RaycastHit hit;
            line.SetPosition(0, gunEnd.position);
            if ()
            {

            }
        }
    }
}
