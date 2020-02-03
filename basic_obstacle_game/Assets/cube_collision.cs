﻿using UnityEngine;
using UnityEngine.UI;
public class cube_collision : MonoBehaviour
{
    static int score = 0;
    // public GameObject txt;
    public Text txt;
    void OnCollisionEnter(Collision info)
    {
        // Debug.Log(info.collider.name);
        // if(info.collider.name=="obstacle")
        if(info.collider.tag=="Obstacle")
            Debug.Log("Obstacle hit");
        if(info.collider.tag=="Coin")
        {
            score +=1;
            Debug.Log("Coin hit. Score: " + score);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "SCORE: " + score.ToString();   
    }
}
