using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    //Reference to projectile's Rigid Body
    public Rigidbody2D projectile;

    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = transform.up * moveSpeed;
        Debug.Log(transform.forward);
    }
    
}
