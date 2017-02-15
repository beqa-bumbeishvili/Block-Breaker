using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    public LevelController LevelController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        LevelController.LoadWinScene();
    }

}
