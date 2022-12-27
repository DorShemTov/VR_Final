using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] int hp;
    [SerializeField] int rocks;

    public void AddRockAmount(int amount)
    {
        rocks += amount;
        Debug.Log("added" + amount + " now i have " + rocks);
    }

    public void AddSpeed(int amount) //todo, make this work
    {
        //todo
        //figure out if reducing or adding waight gain speed
        Debug.Log("added" + amount + " now i have " + speed);
    }

    public void AddHP(int amount)
    {
        hp += amount;
        Debug.Log("added" + amount + " now i have " + hp);

    }

    public void TakeDamage(int amount)
    {
        hp -= amount;
    }

    private void Update()
    {
        if (hp<= 0)
        {
            //print("dead");
        }
    }
    
}
