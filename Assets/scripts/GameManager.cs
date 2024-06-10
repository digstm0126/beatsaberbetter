using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Scene Scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void restart()
    {
        SceneManager.LoadScene("gorilaz");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
