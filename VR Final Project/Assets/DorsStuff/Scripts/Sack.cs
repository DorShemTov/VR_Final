using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Sack : MonoBehaviour
{
    [SerializeField] public GameManager gamemanager;
    [SerializeField] public int Amount;
    public abstract void MySackFanc();

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rock"))
        {
            MySackFanc();
        }
    }


}
