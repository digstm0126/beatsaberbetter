using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField]
    float firstBeatOffset;

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



    public AudioClip muicTrack;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        secPerBeat = 60f / songBpm;

        dspSongTime = (float)AudioSettings.dspTime;

        playMusicTrack();
    }

    void playMusicTrack()
    {
        audioSource.PlayOneShot(muicTrack);
    }
    // Update is called once per frame
    void Update()
    {
        songPosition = (float)(AudioSettings.dspTime - dspSongTime - firstBeatOffset);

        songPositionInBeats = songPosition / secPerBeat;
    }
}
