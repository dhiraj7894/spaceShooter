using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public float speed;
    bool d, u;
    // Start is called before the first frame update
    void Start()
    {
        d = u = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 4)
        {
            u = true;
            d = false;
            
        }
        if(transform.position.y >= -1.5)
        {
            d = true;
            u = false;
            
        }
        if (d)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (u)
        {
            transform.Translate(Vector3.up * -speed * Time.deltaTime);
        }
    }
}
