using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Score;
    public Text ScoreText;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {

    }
    public void UpdateScore()
    {
        ScoreText.text = "Score " + Score;
    }

    void Update()
    {
        
    }
}
    
