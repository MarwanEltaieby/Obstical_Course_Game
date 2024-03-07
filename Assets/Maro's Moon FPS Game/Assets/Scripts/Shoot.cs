using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    [SerializeField] float speed = 1000f;
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject moon;
    [SerializeField] float fireRateTimer= 1f;
    [SerializeField] int ammo = 5;
    [SerializeField] Text ammoText;
    private bool readyToFire = true;

    private void Start() {
        ammoText.text = "Ammo: " + ammo;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && ammo > 0)
        {
            if (readyToFire) 
            {
                ShootMoon();
                readyToFire = false;
            } 
        }

        if (!readyToFire)
        {
            fireRateTimer -= Time.deltaTime;
            if (fireRateTimer <= 0) {
                readyToFire = true;
                fireRateTimer = 0.5f;
            }
        }
    }

    void ShootMoon()
    {
        GameObject shootingObj = Instantiate(moon, spawnPoint.position, moon.transform.rotation);
        Rigidbody myBody = shootingObj.GetComponent<Rigidbody>();
        myBody.AddForce(spawnPoint.forward * Time.deltaTime * speed, ForceMode.Impulse);
        ammo--;
        ammoText.text = "Ammo: " + ammo;
    }
}
