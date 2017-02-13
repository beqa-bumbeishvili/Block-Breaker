using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 PaddleCurrentPosition = new Vector3(0.5f, this.transform.position.y, 0f);

        float MousePositionUnit = Input.mousePosition.x / Screen.width * 16;

        PaddleCurrentPosition.x = Mathf.Clamp(MousePositionUnit, 0.5f, 15.5f);

        transform.position = PaddleCurrentPosition;
	}
}
