using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
 
    public GameObject ballPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ballSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator ballSpawner()
    {
        Vector2 vect = new Vector2(Random.Range(0, 10), 5.0f);
        Instantiate(ballPrefab, vect, Quaternion.identity);
        yield return new WaitForSeconds(2f);
        StartCoroutine(ballSpawner());
    }
}
