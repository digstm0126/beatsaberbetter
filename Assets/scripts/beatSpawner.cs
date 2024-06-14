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

    List<note> CurntSong;

    List<note> gorilaz = new List<note>();

    public AudioClip gorilazClip;

    List<note> Song2 = new List<note>();

    public AudioClip Song2Clip;








    void spawnBeat()
    {
        Instantiate(cubes[CurntSong[notenumber].colur - 1], spawnpoints[CurntSong[notenumber].postion - 1]);
        Instantiate(BALLS[CurntSong[notenumber].colur - 1], new Vector3(spawnpoints[CurntSong[notenumber].ballpostion - 1].position.x, spawnpoints[CurntSong[notenumber].ballpostion - 1].position.y, spawnpoints[CurntSong[notenumber].ballpostion - 1].position.z - CurntSong[notenumber].balldistintce), new Quaternion(0,180,0,0));

    }

    public void garilaz()
    {
        

        //ba ba bum bumb ba ba
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
        //4 BLANK




        //4 altartating red blue pull down
        gorilaz.Add(new note(7, 60, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 62, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 64, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 66, 3, 0, 1, 1));
        //4 altartating red blue pull up
        gorilaz.Add(new note(7, 68, 1, 0, 1, 1));
        gorilaz.Add(new note(9, 70, 3, 0, 2, 1));
        gorilaz.Add(new note(7, 72, 1, 0, 1, 1));
        gorilaz.Add(new note(9, 74, 3, 0, 2, 1));
        //4 altartating red blue pull left to right
        gorilaz.Add(new note(3, 76, 1, 0, 1, 1));
        gorilaz.Add(new note(9, 78, 7, 0, 2, 1));
        gorilaz.Add(new note(3, 80, 1, 0, 1, 1));
        gorilaz.Add(new note(9, 82, 7, 0, 2, 1));
        //4 altartating red blue pull rigt to left
        gorilaz.Add(new note(1, 84, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 86, 9, 0, 2, 1));
        gorilaz.Add(new note(1, 88, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 90, 9, 0, 2, 1));
        //4 BLANK




        //4 red pull down right
        gorilaz.Add(new note(9, 98, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 100, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 102, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 104, 1, 0, 2, 1));
        //4 blue pull down left
        gorilaz.Add(new note(7, 106, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 108, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 110, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 112, 3, 0, 1, 1));
        //4 altartating red blue pull down
        gorilaz.Add(new note(7, 114, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 114, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 116, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 118, 3, 0, 1, 1));
        //4 altartating red blue pull up
        gorilaz.Add(new note(7, 120, 1, 0, 1, 1));
        gorilaz.Add(new note(9, 122, 3, 0, 2, 1));
        gorilaz.Add(new note(7, 124, 1, 0, 1, 1));
        gorilaz.Add(new note(9, 126, 3, 0, 2, 1));
        //4 red pull down right
        gorilaz.Add(new note(9, 128, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 130, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 132, 1, 0, 2, 1));
        gorilaz.Add(new note(9, 134, 1, 0, 2, 1));
        //4 blue pull down left
        gorilaz.Add(new note(7, 136, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 138, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 140, 3, 0, 1, 1));
        gorilaz.Add(new note(7, 142, 3, 0, 1, 1));
        //143 ba ba ba ba ba
        gorilaz.Add(new note(7, 143, 3, 0, 1, 1));
        gorilaz.Add(new note(9, 145, 1, 0, 2, 1));
        gorilaz.Add(new note(7, 148, 3, 0, 1, 1));
        gorilaz.Add(new note(9, 149, 1, 0, 2, 1));
        gorilaz.Add(new note(7, 152, 3, 0, 1, 1));
        gorilaz.Add(new note(9, 153, 1, 0, 2, 1));
        gorilaz.Add(new note(7, 156, 3, 0, 1, 1));
        gorilaz.Add(new note(9, 157, 1, 0, 2, 1));

        CurntSong = gorilaz;

        nextBeatToSpawnNote = (float)CurntSong[0].onbeat;

        soundManager.songBpm = 90;

        soundManager.firstBeatOffset = 10;

        nextBeatToSpawnNote = 1;

        soundManager.setTrack(gorilazClip);

        gameObject.transform.position = hitpoint.transform.position + new Vector3(0, 0, 60 / soundManager.songBpm * soundManager.firstBeatOffset);
    }

    public void song2Make()
    {
        //get pranked
        Song2.Add(new note(1, 0, 3, 0, 1, 1));
        Song2.Add(new note(1, 2, 1, 0, 2, 1));
        Song2.Add(new note(1, 5, 3, 0, 1, 1));
        Song2.Add(new note(1, 6, 1, 0, 2, 1));
        Song2.Add(new note(1, 9, 3, 0, 1, 1));
        Song2.Add(new note(1, 10, 1, 0, 2, 1));
        Song2.Add(new note(1, 13, 3, 0, 1, 1));
        Song2.Add(new note(1, 14, 1, 0, 2, 1));

        CurntSong = Song2;

        nextBeatToSpawnNote = (float)CurntSong[0].onbeat;

        soundManager.songBpm = 90;

        soundManager.firstBeatOffset = 12;

        nextBeatToSpawnNote = 1;

        soundManager.setTrack(Song2Clip);

        gameObject.transform.position = hitpoint.transform.position + new Vector3(0, 0, 60 / soundManager.songBpm * soundManager.firstBeatOffset);
    }

    // Start is called before the first frame update
    void Start()
    {

        

        

    }

    // Update is called once per frame
    void Update()
    {
        if (soundManager.songPositionInBeats >= (float)nextBeatToSpawnNote && notenumber < CurntSong.Count - 1)
        {
            spawnBeat();
            notenumber += 1;
            nextBeatToSpawnNote = (float)CurntSong[notenumber].onbeat;
        }
    }
}
