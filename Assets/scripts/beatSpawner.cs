using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beatSpawner : MonoBehaviour
{
    public GameObject[] cubes;

    public Transform[] spawnpoints;

    public SoundManager soundManager;

    float nextBeatToSpawnNote = 0.0f;



    void spawnBeat()
    {
        Instantiate(cubes[Random.Range(0, cubes.Length)], spawnpoints[Random.Range(0, spawnpoints.Length)]);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (soundManager.songPositionInBeats >= nextBeatToSpawnNote)
        {
            spawnBeat();
            nextBeatToSpawnNote += 4.0f;
        }
    }
}
