using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class playerMovements : MonoBehaviour
{
    public static playerMovements pm;

    [SerializeField]
    private float _speed = 3, dirX, dirY;
    private float speedMult = 3;
    private Rigidbody2D rb;
    public GameObject thrustMini1, thrustMini2, thrustMax,shield;
    public bool isShieldActivated = false;
    public bool isPowerUpActivated = false;
    public bool isSpeedUpActivated = false;
    void Start()
    {
        pm = this;
        thrustMax.SetActive(false);
        thrustMini1.SetActive(true);
        thrustMini2.SetActive(true);
        shield.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0,-3,0);
    }

    // Update is called once per frame
    void Update()
    {
        movement2();
        movement();
        if (isShieldActivated)
        {
            shield.SetActive(true);
        }
        else
        {
            shield.SetActive(false);
        }
    }
    void movement()
    {
        float HoriInput = Input.GetAxis("Horizontal");
        float VerInput = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(HoriInput, VerInput, 0);

        if (isSpeedUpActivated)
        {
            transform.Translate(dir * _speed/16 * speedMult * Time.deltaTime);
            thrustMax.SetActive(true);
            thrustMini1.SetActive(false);
            thrustMini2.SetActive(false);
        }
        else
        {
            transform.Translate(dir * _speed/16 * Time.deltaTime);
            thrustMax.SetActive(false);
            thrustMini1.SetActive(true);
            thrustMini2.SetActive(true);
        }

        if (transform.position.x > 2.5)
        {
            transform.position = new Vector3(2.5f, transform.position.y, 0);
        }
        else if (transform.position.x < -2.5)
        {
            transform.position = new Vector3(-2.5f, transform.position.y, 0);
        }
        else if (transform.position.y > 2)
        {
            transform.position = new Vector3(transform.position.x, 2, 0);
        }
        else if (transform.position.y < -4.3f)
        {
            transform.position = new Vector3(transform.position.x, -4.3f, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("powerUp"))
        {
            StartCoroutine(powerUp());
        }

        if (other.gameObject.CompareTag("shield"))
        {
            StartCoroutine(shieldUp());
        }

        if (other.gameObject.CompareTag("speedUp"))
        {
            StartCoroutine(speedBoost());
        }
    }
    IEnumerator speedBoost()
    {
        isSpeedUpActivated = true;
        yield return new WaitForSeconds(5f);
        isSpeedUpActivated = false; 
    }
    IEnumerator powerUp()
    {
        isPowerUpActivated = true;
        yield return new WaitForSeconds(5f);
        isPowerUpActivated = false;
    }
    IEnumerator shieldUp()
    {
        isShieldActivated = true;
        yield return new WaitForSeconds(05f);
        isShieldActivated = false;
    }

    void movement2()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        dirY = CrossPlatformInputManager.GetAxis("Vertical");

        if (isSpeedUpActivated)
        {
            rb.velocity = new Vector2(dirX * (_speed * speedMult) * Time.deltaTime, dirY * (_speed * speedMult) * Time.deltaTime);
            thrustMax.SetActive(true);
            thrustMini1.SetActive(false);
            thrustMini2.SetActive(false);
        }
        else
        {
            rb.velocity = new Vector2(dirX * _speed * Time.deltaTime, dirY * _speed * Time.deltaTime);
            thrustMax.SetActive(false);
            thrustMini1.SetActive(true);
            thrustMini2.SetActive(true);
        }

        if (transform.position.x > 9.6)
        {
            transform.position = new Vector3(-9.6f, transform.position.y, 0);
        }
        else if (transform.position.x < -9.6)
        {
            transform.position = new Vector3(9.6f, transform.position.y, 0);
        }
        else if (transform.position.y > 2)
        {
            transform.position = new Vector3(transform.position.x, 2, 0);
        }
        else if (transform.position.y < -4.3f)
        {
            transform.position = new Vector3(transform.position.x, -4.3f, 0);
        }
    }
}
