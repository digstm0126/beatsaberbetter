using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;

    public float firstBeatOffset;

    //the songs bpm
    public float songBpm;

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



    public AudioClip muicTrack;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        secPerBeat = 60f / songBpm;

        dspSongTime = (float)AudioSettings.dspTime;



    }

    void playMusicTrack()
    {
        audioSource.PlayOneShot(muicTrack);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (songPositionInBeats - firstBeatOffset > 0 && playing == false)
        {
            playMusicTrack();
            playing = true; 

        }

        songPosition = (float)(AudioSettings.dspTime - dspSongTime);

        songPositionInBeats = songPosition / secPerBeat;
    }
}
