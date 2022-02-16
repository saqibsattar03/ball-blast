using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 speed;
    public Transform bulletSpwanPoint;
    public GameObject bulletPrefab;
    private float StartDelay = 0.0f;
    private float repeatDelay = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = new Vector2(20.0f,0.0f);
       // transform.position = new Vector3(0.0f,0.0f,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        moveLeft();
        moveRight();
        if (Input.GetKey(KeyCode.Space))
        {
            InvokeRepeating("bulletFire", StartDelay, repeatDelay);
        }

    }

    void moveLeft() 
    {

		if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            rb.MovePosition(rb.position - speed * Time.deltaTime);
        }
    }

    void moveRight()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + speed * Time.deltaTime);
        }
    }
    void bulletFire()
    {
        Instantiate(bulletPrefab, bulletSpwanPoint.position, Quaternion.identity);
    }

	
	
}
