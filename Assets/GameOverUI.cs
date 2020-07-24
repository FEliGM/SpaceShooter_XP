using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Score score;
    public Text scoreLable;
    public Text highScoreLable;

    private void OnEnable()
    {
        int currentScore = score.GetScore();
        scoreLable.text = "Score: " + score.GetScore();

        //Check highscore
        int highscore = PlayerPrefs.GetInt("highscore",0);
        highScoreLable.text = "Highscore: " + highscore;
        if (currentScore > highscore)
            PlayerPrefs.SetInt("highscore", currentScore);


    }

    public void RestartGame() 
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
