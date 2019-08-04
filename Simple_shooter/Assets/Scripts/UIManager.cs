using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private TextMeshProUGUI ScoreText;
    private Image healthBar;
    private TextMeshProUGUI healthValue;
    public float health = 100f;
    public float scoreValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshProUGUI>();
        healthBar = GameObject.FindGameObjectWithTag("Health").GetComponent<Image>();
        healthValue = GameObject.FindGameObjectWithTag("Health").GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health/100;
        healthValue.text = health + "%";
        ScoreText.text = "SCORE:" + scoreValue;
    }

    public void TakeHealth(float damage)
    {
        health -= damage;

        if(health < 0)
        {
            health = 0;
        }
    }

    public void AddScore(float points)
    {
        scoreValue += points;
    }
}
