using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   // private Rigidbody2D rb;
    //public Vector2 startForce;
    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(startForce, ForceMode2D.Impulse);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            GameObject.FindObjectOfType<GameManager>().panel.SetActive(true);
        }

        else if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            FindObjectOfType<GameManager>().addScore();
            
        }
    }



}
