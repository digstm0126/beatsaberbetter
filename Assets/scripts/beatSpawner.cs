using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.XR.CoreUtils;
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

    public GameObject hitpoint;

    float nextBeatToSpawnNote = 0.0f;

    List<note> gorilaz = new List<note>();





    void spawnBeat()
    {
        Instantiate(cubes[gorilaz[notenumber].colur - 1], spawnpoints[gorilaz[notenumber].postion - 1]);
        Instantiate(BALLS[gorilaz[notenumber].colur - 1], spawnpoints[gorilaz[notenumber].ballpostion - 1]);
    }

    // Start is called before the first frame update
    void Start()
    {

        gorilaz.Add(new note(7, 0, 3, 0, 1));
        gorilaz.Add(new note(9, 4, 1, 0, 2));
        gorilaz.Add(new note(7, 8, 3, 0, 1));
        gorilaz.Add(new note(9, 12, 1, 0, 2));
        gorilaz.Add(new note(7, 16, 3, 0, 1));
        gorilaz.Add(new note(9, 20, 1, 0, 2));


        gorilaz.Sort();

        nextBeatToSpawnNote = (float)gorilaz[0].onbeat;

        

        gameObject.transform.position = hitpoint.transform.position + new Vector3(0, 0, 60 / soundManager.songBpm * soundManager.firstBeatOffset);
  
    }

    // Update is called once per frame
    void Update()
    {
        if (soundManager.songPositionInBeats >= (float)nextBeatToSpawnNote && notenumber < gorilaz.Count - 1)
        {
            spawnBeat();
            notenumber += 1;
            nextBeatToSpawnNote = (float)gorilaz[notenumber].onbeat;
        }
    }
}
