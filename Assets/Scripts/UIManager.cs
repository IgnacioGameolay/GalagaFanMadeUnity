using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] Text scoreText;
    [SerializeField] Text timeText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void UpdateUIScore(int newScore)
    {
        scoreText.text = newScore.ToString();
    }
    public void UpdateUITime(int newTime)
    {
        timeText.text = newTime.ToString();
    }

}
