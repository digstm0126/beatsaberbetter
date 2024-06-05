using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class note
{
    //where the note is spawned
    public int postion;

    //where its spawned 
    public int ballpostion;

    //distintss down the z aces form black
    public int balldistintce;

    //the beat it spawns on
    public float onbeat;

    //color of beat
    public int colur;

    public note(int NewPostion, float NewOnbeat, int newBallpostion, int NewDist, int newcolulr, int newDistintce)
    {
        postion = NewPostion;

        ballpostion = newBallpostion;

        balldistintce = newDistintce;

        onbeat = NewOnbeat;

        colur = newcolulr;
    }

/*    public int CompareTo(note other)
    {
        if (other == null)
        {
            return 1;
        }

        return (onbeat - other.onbeat;
    }*/
}
