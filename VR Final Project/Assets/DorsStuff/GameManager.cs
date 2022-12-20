using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int speed;
    int hp;
    int rocks;

    public void AddRockAmount(int amount)
    {
        rocks += amount;
        Debug.Log("added" + amount +" now i have "+ rocks);
    }

    public void AddSpeed(int amount)
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
}
