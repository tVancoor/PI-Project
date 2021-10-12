using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public Transform projectileSpawn;

    //Projectile's game object
    public GameObject projectile;

    //Firing speed set up
    public float nextFire = 1.0f;
    public float currentTime = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        projectileSpawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    public void shoot()
    {
        currentTime += Time.deltaTime;

        if(Input.GetButton  ("Fire1") && currentTime > nextFire)
        {
            nextFire += currentTime;

            Instantiate(projectile, projectileSpawn.position, projectileSpawn.rotation); //creates the projectile
            nextFire -= currentTime;
            currentTime = 0.8f;
        }
    }
}
