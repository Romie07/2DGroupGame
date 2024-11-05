using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [Header("Debug Info")]
    public bool Dead = false;
    [Header("References")]
    GameObject GameOverCanvas;
    GameObject RoundHandler;
    GameObject PointHandler;

    private Rounds rounds;
    private Points points;


    void Start()
    {
        GameOverCanvas = GameObject.FindGameObjectWithTag("GameOverCanvas");
        RoundHandler = GameObject.FindGameObjectWithTag("RoundHandler");
        rounds = RoundHandler.GetComponent<Rounds>();
        PointHandler = GameObject.FindGameObjectWithTag("PointHandler");
        points = PointHandler.GetComponent<Points>();
    }

    void Update()
    {
        
    }



}
