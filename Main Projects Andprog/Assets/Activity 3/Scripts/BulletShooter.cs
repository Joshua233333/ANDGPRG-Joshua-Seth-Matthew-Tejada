using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{

    public Transform nozzle;
    public GameObject bulletPrefab;
    public int bulletCount = 30;
    public int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloading = false;
    private void Start()
    {
        currentAmmo = bulletCount;
        
        GameManager.Instance.UpdateBulletCount(currentAmmo);
    }

    void Update()
    {
        if (isReloading)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Reload());
            


        }
        if (currentAmmo < 10)
        {
            GameManager.Instance.BulletText.color = new Color(1,0.5f,0);
        }
        if (currentAmmo > 10)
        {
            GameManager.Instance.BulletText.color = Color.white;
        }
        
        if (currentAmmo <= 0)
        {
            currentAmmo = 0;
            GameManager.Instance.BulletText.color = Color.red;
            StartCoroutine(Reload());
            return;


        }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bulletPrefab, nozzle.transform.position, transform.rotation);
                AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.audioClip[2]);
                currentAmmo--;
                GameManager.Instance.UpdateBulletCount(currentAmmo);
            }
        
    }

    IEnumerator Reload()
    {
        isReloading = true;
        GameManager.Instance.UpdateReloading();
        GameManager.Instance.UpdateEmpty();
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = bulletCount;
        GameManager.Instance.UpdateBulletCount(currentAmmo);
        GameManager.Instance.ReloadingFinish();
        GameManager.Instance.EmptyFinished();
        isReloading = false;
        
    }
}
