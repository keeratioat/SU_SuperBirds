using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayManager : MonoBehaviour
{
    public GameObject pipeOriginal;
    public Text textScore;
    public float pipeSpacing = 3;
    public float pipeVerticalVary = 1;
    public int score = 0;
    public GameObject endGameCanvas;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        GenerateLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GenerateLevel()
    {
        for (int i = 0; i < 10; i++)
        {
            var pipe = Instantiate(pipeOriginal);
            pipe.transform.position = new Vector3(i * pipeSpacing, Random.Range(-pipeVerticalVary, pipeVerticalVary), 0);
        }
    }
    public void ScoreUp()
    {
        score++;
        textScore.text = score.ToString();
    }

    public void bestOfScore()
    {
        if (score > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", score);
            highScoreText.text = score.ToString();
        }
    }

    public void loadSence(string name) {
        SceneManager.LoadScene(name);
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highScoreText.text = "0";
    }

    
}