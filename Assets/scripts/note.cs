using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class note : IComparable<note>
{
    //where the note is spawned
    public int postion;

    //the beat it spawns on
    public int onbeat;

    public note(int NewPostion, int NewOnbeat)
    {
        postion = NewPostion;
        onbeat = NewOnbeat;
    }

    public int CompareTo(note other)
    {
        if (other == null)
        {
            return 1;
        }

        return onbeat - other.onbeat;
    }
}
