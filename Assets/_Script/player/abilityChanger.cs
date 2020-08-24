using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abilityChanger : MonoBehaviour
{
    public Sprite[] spaceCraft;
    public SpriteRenderer sR;
    // Start is called before the first frame update
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        sR.sprite = spaceCraft[0];
    }

    // Update is called once per frame
    void Update()
    {
    }
}
