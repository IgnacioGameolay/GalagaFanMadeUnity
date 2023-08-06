using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] wavePrefab;
    [SerializeField] int waveIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") == null)
        {
            if (waveIndex != wavePrefab.Length) //Ojo en un futuro por si no se llegase a spawnear alguna wave por el tema de indices...
            {
                waveIndex++;
            }
            else
            {
                waveIndex = 0;

            }
            //StartCoroutine(SpawnWave());
            Vector2 wavePos = new Vector2(-1, 0);
            Instantiate(wavePrefab[waveIndex], wavePos, Quaternion.identity);
            GameManager.Instance.Wave++;
            
        }
    }
}

    /*
    IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(2);
        waveIndex = 0;
        Vector2 wavePos = new Vector2(-1, 0);
        Instantiate(wavePrefab[waveIndex], wavePos, Quaternion.identity);
        if (waveIndex != wavePrefab.Length) //Ojo en un futuro por si no se llegase a spawnear alguna wave por el tema de indices...
        {
            waveIndex++;
        }
        else
        {
            waveIndex = 0;

        }
    }
}*/
