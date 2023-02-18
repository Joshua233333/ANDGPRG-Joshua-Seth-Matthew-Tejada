using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public GameObject[] bulletPrefab;
    public Transform[] bulletSpawnPoints;
    public float bulletSpeed = 10;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ShootBullets(1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            ShootBullets(2, 1);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ShootBullets(3, 2);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ShootBullets(4, 3);
        }
    }

    private void ShootBullets(int numberOfBullets, int typeOfBullet)
    {
        for (int i = 0; i < numberOfBullets; i++)
        {
            if (i < bulletSpawnPoints.Length)
            {
                var bullet = Instantiate(bulletPrefab[typeOfBullet], bulletSpawnPoints[i].position, bulletSpawnPoints[i].rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoints[i].forward * bulletSpeed;
            }
        }
    }
}

  





 
