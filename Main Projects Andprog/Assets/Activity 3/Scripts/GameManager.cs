using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Score;
    public Text GameOverScoreText;
    public Text ScoreText;
    public Text BulletText;
    public Text ReloadingText;
    public Text EmptyText;
    public GameObject YouWinScreen;
    public GameObject YouLoseScreen;

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

    public void UpdateBulletCount(int value)
    {
        BulletText.text = "Bullet Count  " + value.ToString();
    }
    public void UpdateReloading()
    {
        ReloadingText.text = "Reloading....... ";
    }
    public void ReloadingFinish()
    {
        ReloadingText.text = "";
    }

    public void UpdateEmpty()
    {
        EmptyText.text = "Empty";
    }
    public void EmptyFinished()
    {
        EmptyText.text = "";
    }
    public void GameWins()
    {
        if (Score >= SpawnManager.Instance.SpawnPoints.Length)
        {
            YouWinScreen.SetActive(true);
        }
        
    }
    public void GameLose()
    {
        
        YouLoseScreen.SetActive(true);
        GameOverScoreText.text = "Score: "+ Score;
    }
}
    
