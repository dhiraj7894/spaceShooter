using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leser : MonoBehaviour
{
    public float speed = 8;
    public GameObject leserExplode;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Destroy(Instantiate(leserExplode, transform.position, Quaternion.identity),1);
        }

        if (collision.gameObject.CompareTag("shield"))
        {
            Destroy(this.gameObject);
            Destroy(Instantiate(leserExplode, transform.position, Quaternion.identity), 1);
        }
    }
}
