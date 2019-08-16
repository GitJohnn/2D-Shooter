using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool game = true;
    public GameObject GameOver;
    public GameObject HighScore;
    private TextMeshProUGUI HighScoreText;
    public Button restartBtn;
    public Button quitBtn;
    public float score;
    public float health;

    // Start is called before the first frame update
    void Awake()
    {
        game = true;
        GameOver.SetActive(false);
        HighScore = GameObject.FindGameObjectWithTag("HighScore");
        HighScore.SetActive(false);
        HighScoreText = HighScore.GetComponent<TextMeshProUGUI>();
        health = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>().health;
        restartBtn = GameObject.Find("RestartButton").GetComponent<Button>();
        restartBtn.gameObject.SetActive(false);
        quitBtn = GameObject.Find("QuitButton").GetComponent<Button>();
        quitBtn.gameObject.SetActive(false);

    }

    private void Update()
    {
        CheckGameOver();
        HighScoreText.text = "HighScore: " + score;
        score = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>().scoreValue;
        health = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>().health;
    }

    void CheckGameOver()
    {
        if (health > 0)
        {
            game = true;
        }
        else if(health <= 0)
        {
            game = false;
            HighScore.SetActive(true);
            GameOver.SetActive(true);
            restartBtn.gameObject.SetActive(true);
            quitBtn.gameObject.SetActive(true);
        }
    }

}
