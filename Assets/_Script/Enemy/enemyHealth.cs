using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public float currentHealth = 10;
    public GameObject explosive;
    private float _maxHealth = 10;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(Instantiate(explosive, transform.position, Quaternion.identity), 1);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("shieldUp"))
        {
            GameManager.gameManager.updateScore(2f);
            Destroy(this.gameObject);
            Destroy(Instantiate(explosive, transform.position, Quaternion.identity), 1);
        }
    }
}
