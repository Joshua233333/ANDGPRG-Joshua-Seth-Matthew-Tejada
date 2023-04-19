using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float speed = 10.0f;
    

    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        float translation1 = Input.GetAxis("Vertical") * speed;



        translation *= Time.deltaTime;
        translation1 *= Time.deltaTime;


        transform.Translate(translation, translation1, 0);
        





    }
}
