using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletAttack : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float hp = 1;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            hp--;

            if (hp <= 0)
            {
                GameManager.Instance.Score+=1;
                GameManager.Instance.UpdateScore();
                
                for (int i = 0; i < 2; i++)
                {
                    AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.audioClip[i]);
                }
                //score.AddScore(1);
                Debug.Log(GameManager.Instance.Score);
                Destroy(this.gameObject);
                
                
            }

        }
    }
    
    
}
