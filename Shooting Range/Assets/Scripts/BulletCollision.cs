using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCollision : MonoBehaviour
{

    public GameObject objectToSpawn;
    private GameObject spawnedObject;
    public float hp = 1;
    void Start()
    {
        
    }

    


    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            
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
           
            Destroy(spawnedObject);
            spawnedObject = null;

        }
    }


void Update()
    {
        
    }
}
