using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public int maxHits;
    int hitCounter;
    public LevelController LevelController;

	// Use this for initialization
	void Start () {
        hitCounter = 0;
        LevelController = GameObject.FindObjectOfType<LevelController>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitCounter++;
        SimulateWin();
    }
    // TODO remove this method when we actually can win
    void SimulateWin()
    {
        LevelController.LoadWinScene();
    }

}
