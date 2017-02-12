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
        SceneManager.LoadScene("Win");
    }
}
