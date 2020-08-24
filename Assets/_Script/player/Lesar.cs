using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesar : MonoBehaviour
{
    public float speed = 8;
    public GameObject leserExplode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if(transform.position.y > 6 )
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.gameManager.updateScore(2f);
            Destroy(this.gameObject);
            Destroy(Instantiate(leserExplode, transform.position, Quaternion.identity), 1);
        }
    }
}
