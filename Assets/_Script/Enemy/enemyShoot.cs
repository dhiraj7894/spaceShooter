using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    public GameObject leser;
    public Transform[] shootPoint;
    public float coolDown = 1;
    public float fireRate = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coolDown -= Time.deltaTime;
        if (coolDown <= 0)
        {
            spwanLeser();
            coolDown = 2 / fireRate;
        }

    }
    void spwanLeser()
    {
        Instantiate(leser, shootPoint[0].position, Quaternion.identity);       
    }
}
