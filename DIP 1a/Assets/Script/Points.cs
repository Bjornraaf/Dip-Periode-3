using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int Score = 0;
    public Text ScoreText;


    public void Henk()
    {
        if (Input.GetKey(KeyCode.Mouse0) == true)
        {
            AddScore();
        }
    }
        void AddScore()
    {
        
        Score++;
        ScoreText.text = Score.ToString();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
