using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    private LevelController LevelController;

    private void Start()
    {
        LevelController = GameObject.FindObjectOfType<LevelController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        LevelController.LoadLostScene();
    }

}
