using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    

    public Rigidbody2D player;

    private float RotateSpeed = -2f;
    private float Radius = -17.0f;
    private float radialSpeed = 0.5f;

    private Vector2 _centre;
    private float _angle;


    // Start is called before the first frame update
    void Start()
    {
        //_centre = transform.position;
        player = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();


        Vector3 mouseScreen = Input.mousePosition;
        Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);
        
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90);
    }

    public void MovePlayer()
    {
        //_angle += RotateSpeed * Time.deltaTime;

        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
        transform.position = _centre + offset;

        Radius += (Input.GetAxis("Vertical")) * radialSpeed;
        _angle += (Input.GetAxis("Horizontal")) * RotateSpeed * Time.deltaTime;
    }
}
