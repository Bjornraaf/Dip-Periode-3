using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public int Ecore = 0;

    private void OnTriggerEnter(Collider Other)
    {
        EndScore();
        if (Ecore == 2)
        {
            IveBeenClicked();
        }
    }
    void EndScore()
    {
        Ecore++;
        Debug.Log("Hell");


    }
    public void IveBeenClicked()
    {
        Debug.Log("Noice");
        SceneManager.LoadScene("Start");
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
