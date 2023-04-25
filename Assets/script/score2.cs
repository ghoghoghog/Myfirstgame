using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class score2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    [SerializeField] private TextMeshProUGUI text2;
    private static int _myScore = 0;
    
    private int _bestScore = 0;
    
    
    public static score2 Instance { get; private set; }
    public GameObject obj;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    public int myScore
    {
        get => _myScore;
        set
        {
            _myScore = value;
            if (_myScore > _bestScore)
            {
                _bestScore = _myScore;
                PlayerPrefs.SetInt("bestScore", _bestScore);
            }

            printScore();
        }
    }

    private void printScore()
    {
        text.text = $"My Score : {_myScore}";
        text2.text = $"Best Score : {_bestScore}";
    }

    public int bestScore
    {
        get => _bestScore;
    }

    private void Start()
    {
        _bestScore = PlayerPrefs.GetInt("bestScore", 100);
        myScore = 0;
    }

    
}
