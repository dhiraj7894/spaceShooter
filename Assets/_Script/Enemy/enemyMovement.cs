using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed = 4;
    public bool isPlayerDied = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if(transform.position.y <= -5 && playerHealth.health.currentHealth > 0)
        {
            float randomX = Random.Range(-8, 9);
            transform.position = new Vector3(randomX, 7, 0);
        }

        if(transform.position.y <= -5 && isPlayerDied)
        {
            Destroy(gameObject);
        }
    }
    public void getPlayerDiedInfo()
    {
        isPlayerDied = true;

    }
}
