using UnityEngine;

public class extraAbilityMove : MonoBehaviour
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
        if(transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
    }
    public void getPlayerDiedInfo()
    {
        isPlayerDied = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
