using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playerHealth : MonoBehaviour
{
    public static playerHealth health;
    public float currentHealth = 10;
    public GameObject explode;
    public Slider slider;
    public TextMeshProUGUI healthText;
    private float _maxHealth = 10;      

    void Start()
    {
        health = this;
        slider.value = _maxHealth;
    }

    void Update()
    {
        slider.value = currentHealth;
        healthText.text = currentHealth.ToString();
        if(currentHealth < 1)
        {
            Destroy(Instantiate(explode, transform.position, Quaternion.identity), 1);
            Destroy(this.gameObject, 0.2f);
            FindObjectOfType<enemyMovement>().getPlayerDiedInfo();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            currentHealth -= 1;
        }
    }
}
