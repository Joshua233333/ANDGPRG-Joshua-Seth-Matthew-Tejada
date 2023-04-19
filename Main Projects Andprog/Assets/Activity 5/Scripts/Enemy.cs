using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp = 2;
    public float mSpeed;
    public float fireRate;

    public void TakeDamage()
    {
        
                hp--;

                if (hp <= 0)
                {
                    GameManager.Instance.Score += 1;
                    GameManager.Instance.UpdateScore();

                    for (int i = 0; i < 2; i++)
                    {
                        AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.audioClip[i]);
                    }
                    //score.AddScore(1);
                    Debug.Log(GameManager.Instance.Score);
                    GameManager.Instance.GameWins();
                    Destroy(this.gameObject);


                }

            }
        }
    



