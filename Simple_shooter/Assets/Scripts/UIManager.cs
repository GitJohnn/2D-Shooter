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
    private float health = 100f;
    private float scoreValue = 0;

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
    }

    public void AddScore(float points)
    {
        scoreValue += points;
    }
}
