using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour
{
    public Transform projectileSpawn;

    //Projectile's game object
    public GameObject projectile;

    //Firing speed set up
    public float nextFire = 1.0f;
    public float currentTime = 0.0f;    

    // Start is called before the first frame update
    void Start()
    {
        projectileSpawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemyShoot();
    }

    public void enemyShoot()
    {
        currentTime += Time.deltaTime;

        if ( currentTime > nextFire)
        {
            nextFire += currentTime;

            Instantiate(projectile, projectileSpawn.position, projectileSpawn.rotation); //creates the projectile            
            nextFire -= currentTime;
            currentTime = 0.0f;
        }        
    }
}
