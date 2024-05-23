using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject shatedobj;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(shatedobj, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
