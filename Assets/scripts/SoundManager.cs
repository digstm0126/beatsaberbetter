using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;

    public float firstBeatOffset;

    //the songs bpm
    public float songBpm;

    public float beatSpotNice;

    //song spot in beats
    public float songPositionInBeats;

    //number of seconds per beat
    float secPerBeat;

    //cuent song spot
    float songPosition;

    //how long the song been going for
    float dspSongTime;

    //see if its plaing 
    bool playing = false;

    public bool startgame = false;

    public bool runing = false;

    public AudioClip muicTrack;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        secPerBeat = 60f / songBpm;

        dspSongTime = (float)AudioSettings.dspTime;

        songPositionInBeats = -1;


    }

    void playMusicTrack()
    {
        audioSource.PlayOneShot(muicTrack);
        
    }

    public void clicked()
    {
        startgame = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (songPositionInBeats - firstBeatOffset > 0 && playing == false)
        {
            playMusicTrack();
            playing = true; 


        }

        if (startgame == true)
        {
            runing = true;

            dspSongTime = (float)AudioSettings.dspTime;
            startgame = false;
        }

        if (runing == true)
        {
            songPosition = (float)(AudioSettings.dspTime - dspSongTime);

            songPositionInBeats = songPosition / secPerBeat;
        }

        beatSpotNice = songPositionInBeats - firstBeatOffset;

    }
}
