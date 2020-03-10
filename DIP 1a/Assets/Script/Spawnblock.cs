using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawnblock : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject PreBlock;
    public int Score = 0;
    public Text ScoreText;
    void AddScore()
    {

        Score++;
        ScoreText.text = Score.ToString();

    }

    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject obj = Instantiate(PreBlock, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity) as GameObject;
                obj.transform.Translate(0, 0, -1);
                AddScore();
            }
        }
    }
}
