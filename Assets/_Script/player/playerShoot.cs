using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject leser;
    public fireButton fire;
    public Transform[] shootPoint;
    public float coolDown = 1;
    public float fireRate = 2;

    [SerializeField]
    private float leserShoot = 1;

    private bool _shoot = false;
    void Update()
    {

        if (playerMovements.pm.isPowerUpActivated)
        {
            leserShoot = 3;
        }
        else
        {
            leserShoot = 1;
        }

        coolDown -= Time.deltaTime;
            if (coolDown <= 0)
            {
                spwanLeser();
                coolDown = 1 / fireRate;
            }
    }

    void spwanLeser()
    {
        switch (leserShoot)
        {
            case 1:
                Instantiate(leser, shootPoint[0].position, Quaternion.identity);
                break;
            case 3:
                Instantiate(leser, shootPoint[0].position, Quaternion.identity);
                Instantiate(leser, shootPoint[1].position, Quaternion.identity);
                Instantiate(leser, shootPoint[2].position, Quaternion.identity);
                break;
        }
        

    }
}
