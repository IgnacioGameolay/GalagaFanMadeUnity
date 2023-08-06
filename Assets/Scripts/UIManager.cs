using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI waveText;

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
    public void UpdateUIWave(int newWave)
    {
        waveText.text = newWave.ToString();
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        Application.Quit();
    }

}
