using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;
    public GameObject[] Enemies;
    public GameObject[] PowerUps;
    public Transform[] SpawnPointsPu;
    public Transform[] SpawnPoints;
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
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            int rnumber = Random.Range(0, Enemies.Length);
            Instantiate(Enemies[rnumber], SpawnPoints[i].position, Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
