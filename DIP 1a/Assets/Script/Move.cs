using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.position = transform.position + new Vector3(0, -0.1f, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.position = transform.position + new Vector3(-0, 0.1f, 0);
        }
        if (transform.position.y <= 5)
        {
            transform.position = new Vector3(0, 5, -13.5f);
        }
    }
}
