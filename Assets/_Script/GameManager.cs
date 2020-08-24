using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public Slider slider;
    public TextMeshProUGUI scoreText;
    public float _score=0;
    void Start()
    {
        gameManager = this;
        slider.value = 0;
        Application.targetFrameRate = 60;
        //Cursor.lockState = CursorLockMode.Locked ;
    }

    private void Update()
    {
        slider.value = _score;
        scoreText.text = _score.ToString();
    }
    public void updateScore(float score)
    {
        _score = _score + score;
    }
}
