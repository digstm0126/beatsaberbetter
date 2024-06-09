using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject shatedobj;

    public GameObject hitbox;

    public int score;

    private void Start()
    {
        hitbox = GameObject.Find("hit point");
    }

    private void Update()
    {
        if (gameObject.transform.position.z < hitbox.transform.position.z + 1 & gameObject.transform.position.z > hitbox.transform.position.z + -1) 
        {
            score = 1;
        }
        else
        {
            score = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == gameObject.layer && other.gameObject.tag == "moving ball")
        {
            Debug.Log(score);
            scoreManager.instance.addpoint(score); 
            Instantiate(shatedobj, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }


}
