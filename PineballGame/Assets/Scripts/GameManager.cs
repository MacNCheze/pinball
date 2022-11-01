using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float score=0f;
    public TMP_Text displyTxt;
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {        
        if (displyTxt == null)
        {
            displyTxt = GameObject.FindWithTag("ScoreDisplay")
                .GetComponent<TMP_Text>();
            displyTxt.text="Score "+ score;
        }
    }
    private void Update()
    {
        displyTxt.SetText("Score: " + score);
    }
}
