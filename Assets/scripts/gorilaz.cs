using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gorilaz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<note> gorilaz = new List<note>();

        gorilaz.Add(new note(1, 1));
        gorilaz.Add(new note(3, 9));
        gorilaz.Add(new note(4, 8));


        gorilaz.Sort();
        foreach (note note in gorilaz)
        {
            Debug.Log(note.onbeat);
        }




    }

}
