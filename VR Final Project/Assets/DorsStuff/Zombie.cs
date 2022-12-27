using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] int speed =2 ;
    [SerializeField] int damage =2 ;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Rock"))
        {
            collision.gameObject.GetComponent<Rock>().collided = true;
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("GameManager"))
        {
            collision.gameObject.GetComponent<GameManager>().TakeDamage(damage);
        }
    }
    private void Start()
    {
        transform.LookAt(gameManager.transform);
    }

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    
}
