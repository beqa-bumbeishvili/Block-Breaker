using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {
	
    public void LoadLevelOneScene()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void LoadWinScene()
    {
        SceneManager.LoadScene("Win Screen");
    }
    public void LoadLostScene()
    {
        SceneManager.LoadScene("Lose Screen");
    }

    public void LoadStartGame()
    {
        SceneManager.LoadScene("Start");
    }

    public void LoadNextLevel()
    {
        var NextSceneIndex = SceneManager.GetActiveScene().buildIndex+1;
        SceneManager.LoadScene(NextSceneIndex);
    }
}
