using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class beatSpawner : MonoBehaviour
{
    public GameObject[] cubes;

    public GameObject[] BALLS;    

    public Transform[] spawnpoints;

    public Transform[] BallSpawnpoints;

    public SoundManager soundManager;

    public int notenumber;

    float nextBeatToSpawnNote = 0.0f;

    List<note> gorilaz = new List<note>();





    void spawnBeat()
    {
        Instantiate(cubes[Random.Range(0, cubes.Length)], spawnpoints[Random.Range(0, spawnpoints.Length)]);
        //Instantiate(BALLS[Random.Range(0, BALLS.Length)], BallSpawnpoints[Random.Range(0, BallSpawnpoints.Length)]);
    }

    // Start is called before the first frame update
    void Start()
    {


        gorilaz.Add(new note(7, 0, 3, 0));
        gorilaz.Add(new note(9, 4, 1, 0));
        gorilaz.Add(new note(7, 8, 3, 0));
        gorilaz.Add(new note(9, 12, 1, 0));
        gorilaz.Add(new note(7, 16, 3, 0));
        gorilaz.Add(new note(9, 20, 1, 0));


        gorilaz.Sort();
        foreach (note note in gorilaz)
        {
            Debug.Log(note.onbeat);
        }

        nextBeatToSpawnNote = (float)gorilaz[0].onbeat;
    }

    // Update is called once per frame
    void Update()
    {

        if (soundManager.songPositionInBeats >= nextBeatToSpawnNote)
        {
            spawnBeat();
            Debug.Log("beat");
            nextBeatToSpawnNote = (float)gorilaz[notenumber].onbeat;
            notenumber += 1;
        }
    }
}
