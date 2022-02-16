using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public GameObject panel;
    public Button button;
    public Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "Score: " + score; 
    }
    public void addScore() 
    {
        score += 10;
    }
    public void restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }

}
