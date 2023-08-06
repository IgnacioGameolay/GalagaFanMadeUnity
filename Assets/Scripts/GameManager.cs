using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] int score;
    [SerializeField] int time;
    [SerializeField] public int wave;
    [SerializeField] SceneAsset MainMenu;

    public int Score
    {
        get => score;
        set
        {
            score = value;
            UIManager.Instance.UpdateUIScore(score);

        }
    }
    public int Wave
    {
        get => wave;
        set
        {
            wave = value;
            UIManager.Instance.UpdateUIWave(wave);
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void Update()
    {
        
    }
    public void Start()
    {
        StartCoroutine(updateTime());
    }

    IEnumerator updateTime()
    {
        while (true) { 
            yield return new WaitForSeconds(1);
            time++;
            UIManager.Instance.UpdateUITime(time);
        }
    }    
}
