using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    bool collided;
    float timer = 0;
    private void OnCollisionEnter(Collision collision)
    {
        collided = true;
    }

    private void Update()
    {
       /* if (collided)
        {
            timer += Time.deltaTime;
        }

        if (timer > 20)
        {
            gameObject.SetActive(false);
        }*/

    }
}
