using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanManager : MonoBehaviour
{
    public GameObject enemy;
    public playerHealth health;
    public GameObject[] ability;
    public float enemySpwanRate = 2, abilitySpwanRate = 1;
    void Start()
    {
        StartCoroutine(spwanEnemy());
        StartCoroutine(spwanAbility());
    }

    IEnumerator spwanEnemy()
    {
        while (health.currentHealth > 0)
        {
            Vector3 posToSpwan = new Vector3(Random.Range(-2.4f, 2.5f), 5.5f, 0);
            Instantiate(enemy, posToSpwan, Quaternion.Euler(180,0,0));
            yield return new WaitForSeconds(enemySpwanRate);
        }
        

    }
    IEnumerator spwanAbility()
    {
        while (health.currentHealth > 0)
        {
            int i = Random.Range(0, 3);
            Vector3 posToSpwan = new Vector3(Random.Range(-2.4f, 2.5f), 5.5f, 0);
            Instantiate(ability[i], posToSpwan, Quaternion.Euler(180, 0, 0));
            yield return new WaitForSeconds(abilitySpwanRate);
        }
    }
}
