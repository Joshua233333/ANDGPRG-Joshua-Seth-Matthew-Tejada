using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlertZone : MonoBehaviour
{

    public GameObject objectToSpawn;
    private GameObject spawnedObject;
    public float hp = 1;
   
    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.audioClip[3]);
            spawnedObject = Instantiate(objectToSpawn, objectToSpawn.transform.position, transform.rotation);
            spawnedObject.SetActive(true);
            Destroy(spawnedObject, 1f);
            
            Debug.Log(spawnedObject.name);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {

            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.audioClip[4]);
            Destroy(spawnedObject);
            spawnedObject = null;

        }
    }



}
