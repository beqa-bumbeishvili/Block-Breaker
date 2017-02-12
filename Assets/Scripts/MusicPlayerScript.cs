using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);   
    }

}
