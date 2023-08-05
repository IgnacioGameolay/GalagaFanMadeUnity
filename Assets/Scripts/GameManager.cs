using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] int score;


    public int Score
    {
        get => score;
        set
        {
            score = value;
        }
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    
}
