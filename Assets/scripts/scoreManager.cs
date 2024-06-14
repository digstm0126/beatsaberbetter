using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{   
    public static scoreManager instance;

    public TMP_Text scoreText;

    public int scoreCount = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
    
        scoreText.text = "score" + scoreCount.ToString();

    }

    public void addpoint(int scoretoadd)
    {
        scoreCount = scoreCount + scoretoadd;
        scoreText.text = "score: " + scoreCount.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
