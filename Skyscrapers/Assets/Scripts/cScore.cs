using UnityEngine;
using UnityEngine.UI;

public class cScore : MonoBehaviour
{
    public Text scoreText;
    public Text highScore;    

    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    void Update()
    {
        scoreText.text = BoxScript.score.ToString();

        if(BoxScript.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", BoxScript.score);
            highScore.text = BoxScript.score.ToString();
        }
    }
}
