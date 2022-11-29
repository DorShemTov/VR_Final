using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingLimbs : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        this.transform.parent = null;
    }
}
