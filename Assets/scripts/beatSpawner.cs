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
        Instantiate(BALLS[gorilaz[notenumber].colur - 1], new Vector3(spawnpoints[gorilaz[notenumber].ballpostion - 1].position.x, spawnpoints[gorilaz[notenumber].ballpostion - 1].position.y, spawnpoints[gorilaz[notenumber].ballpostion - 1].position.z - gorilaz[notenumber].balldistintce), new Quaternion(0,180,0,0));

    }

    // Start is called before the first frame update
    void Start()
    {

        gorilaz.Add(new note(7, 0, 3, 0, 1, 1));
        gorilaz.Add(new note(9, 2, 1, 0, 2, 1));
        gorilaz.Add(new note(7, 5, 3, 0, 1, 1));
        gorilaz.Add(new note(9, 6, 1, 0, 2, 1));
        gorilaz.Add(new note(7, 9, 3, 0, 1, 1));
        gorilaz.Add(new note(9, 10, 1, 0, 2, 1));
        gorilaz.Add(new note(7, 13, 3, 0, 1, 1));
        gorilaz.Add(new note(9, 14, 1, 0, 2, 1));
        //sim 
        gorilaz.Add(new note(9, 17, 6, 0, 2, 0));
        //sima
        gorilaz.Add(new note(1, 17.5f, 4, 0, 1, 0));
        //4 red on side
        gorilaz.Add(new note(9, 22, 6, 0, 2, 0));
        gorilaz.Add(new note(9, 24, 6, 0, 2, 0));
        gorilaz.Add(new note(9, 26, 6, 0, 2, 0));
        gorilaz.Add(new note(9, 28, 6, 0, 2, 0));
        //4 blue pull down left
        gorilaz.Add(new note(7, 30, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 32, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 34, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 36, 3, 0, 1, 1));
        //4 red pull down right
        gorilaz.Add(new note(9, 38, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 40, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 42, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 44, 1, 0, 2, 1));
        //4 blue pull down left
        gorilaz.Add(new note(7, 46, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 48, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 50, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 52, 3, 0, 1, 1));
        //4 red pull down right
        gorilaz.Add(new note(9, 54, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 56, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 58, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 60, 1, 0, 2, 1));






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
