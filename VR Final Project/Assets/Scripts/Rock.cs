using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public bool collided;
    float timer = 0;
   

    private void Update()
    {
        if (collided)
        {
            timer += Time.deltaTime;
        }

        if (timer > 3)
        {
            gameObject.SetActive(false);
        }

    }
}
