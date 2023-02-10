using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletAttack : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Scoring score;
    public float hp = 1;
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            hp--;

            if (hp <= 0)
            {
                score.AddScore(1);
                Destroy(this.gameObject);
                
            }

        }
    }
    
    void Update()
    {
        
     
           
        
    }
}
