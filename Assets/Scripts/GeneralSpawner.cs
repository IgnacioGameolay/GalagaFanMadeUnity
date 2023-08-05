using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] wavePrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWave());
    }
    IEnumerator SpawnWave()
    {
        while (true)
        {
            if (GameObject.FindGameObjectsWithTag("Enemy") == null)
            {
                yield return new WaitForSeconds(2);
                int waveIndex = 0;
                Vector2 wavePos = new Vector2(-1, 0);
                Instantiate(wavePrefab[waveIndex], wavePos, Quaternion.identity);
                if (waveIndex != wavePrefab.Length) //Ojo en un futuro por si no se llegase a spawnear alguna wave por el tema de indices...
                {
                    waveIndex++;
                } else {
                    waveIndex = 0;
                }
            }
        }
    }
}
