using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWidth : MonoBehaviour
{
    private float screenWidth;
    [SerializeField] BoxCollider2D leftWallCollider;
    [SerializeField] BoxCollider2D rightWallCollider;
    // Start is called before the first frame update
    void Awake()
    {
        screenWidth = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f,0.0f)).x;
        Debug.Log(screenWidth);

        // setting colliders at run time
        leftWallCollider.transform.position = new Vector3(-screenWidth - leftWallCollider.size.x / 2.0f, 0.0f, 0.0f);
        rightWallCollider.transform.position = new Vector3(screenWidth + rightWallCollider.size.x / 2.0f, 0.0f, 0.0f);
        Debug.Log(leftWallCollider.size.x);
        Destroy(this);
    }
	

	// Update is called once per frame
	void Update()
    {
    }
}
