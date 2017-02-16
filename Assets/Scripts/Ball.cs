using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;
    private bool GameStarted = false;
    private Vector3 paddleToBallVector;
    private Rigidbody2D rigi;
    private void Awake()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
    }
	
	void Update () {
        if (!GameStarted)
        this.transform.position = paddle.transform.position + paddleToBallVector;

        if (Input.GetMouseButtonDown(0))
        {
            GameStarted = true;
            rigi.AddForce(new Vector2(0, 300f));
            rigi.velocity = new Vector2(1f, 2f);
        }

    }
}
