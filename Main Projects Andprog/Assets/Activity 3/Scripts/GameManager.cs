using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Score;
    public Text ScoreText;

    public void Start()
    {
        AudioManager.Instance.audioSource2.PlayOneShot(AudioManager.Instance.audioClip[5]);
    }
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
   
    public void UpdateScore()
    {
        ScoreText.text = "Score " + Score;
    }

}
    
