using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{

    public Transform nozzle;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, nozzle.transform.position, transform.rotation);
            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.audioClip[2]);
        }
    }
}
