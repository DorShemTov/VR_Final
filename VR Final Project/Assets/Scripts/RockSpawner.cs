using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField] GameObject rockPrefab;
    [SerializeField] List<GameObject> rocks;


    void Start()
    {
        foreach (var item in rocks)
        {
            item.SetActive(false);
        }
        SpawnRock();
    }

    public void SpawnRock()
    {
        rocks[0].gameObject.SetActive(true);
        rocks[0].gameObject.transform.position = this.transform.position;

        rocks.RemoveAt(0);
        
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
   
    
}
