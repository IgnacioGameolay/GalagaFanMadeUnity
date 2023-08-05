using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] int score;
    [SerializeField] int time;


    public int Score
    {
        get => score;
        set
        {
            score = value;
            UIManager.Instance.UpdateUIScore(score);

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
